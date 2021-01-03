using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PEIaPP.Models
{
    public class Dialogproc
    {

        private static string CalculateMultiRegionRPCArray_strSQL;
        //internal static partial class DefineConstants
        //{
        public const int ALLOCATED = 175;
        public const int TEMP = 0;
        // public const int MAINSTREET = 1;
        //public const int TOURISM = 5;
        //public const int MUSEUM = 16;
        //public const int GENERAL = 19;
        //public const int REHABONE = 23;
        //public const int REHABTWO = 27;
        //public const int REHABTHREE = 31;
        //public const int ELEMINR3 = 34;
        //public const int SECTORS = 519;
        //public const int NumberOfMultipleRegions = 2;
        //public const int SICSECTORS = 1001;
        //  public const int ALLOCATED =175;

        //public const int TEMP   =     0;
        public const int MAINSTREET = 1;
        public const int TOURISM = 5;
        public const int MUSEUM = 16;
        public const int GENERAL = 19;
        public const int REHABONE = 23;
        public const int REHABTWO = 27;
        public const int REHABTHREE = 31;
        public const int ISMS = 19;//  GENERAL;
        public const int ISM = 20;//  GENERAL + 1
        public const int IST = 21;//  GENERAL + 2
        public const int ISRH = 22;//  GENERAL + 3

        public const int ELEMINR3 = 34;

        public const int SECTORS = 519;
        public const int NumberOfMultipleRegions = 2;

        public const int SICSECTORS = 1001;



        public double?[] dblCalcVector = new double?[SECTORS];
        public double[] _nVectorSettings = new double[175];

        public double[,] MultiRegionRPCArray = new double[NumberOfMultipleRegions, NumberOfMultipleRegions];

        public List<pckeyvalue> MyRecordset = new List<pckeyvalue>();
        public List<pckeyvalue> RegRecordset = new List<pckeyvalue>();
        public List<pckeyvalue> RestRecordset = new List<pckeyvalue>();

        public List<tblTemp> tbltemp;
        public List<tblDirectEffect> tblDirectEffects;
        public List<tblGeneralIndustry> tblGeneralIndustry = new List<tblGeneralIndustry>();
        public List<tblEconomicBase> tblEconomicBase = new List<tblEconomicBase>();
        public List<tblShare> tblShare = new List<tblShare>();
        public List<tblIndustry> tblIndustry = new List<tblIndustry>();
        public List<tblBase> tblBase = new List<tblBase>();
        List<tblOccupation> tblOccupationsrecords = new List<tblOccupation>();
        public static string strSQL = "";

        public static double result = 0;
        double[] ResultVector = new double[NumberOfMultipleRegions * (SECTORS - 2)];
        //  public static double[] dblCalcVector = new double[DefineConstants.SECTORS];

        public static double dblDirectEmp = 0;
        public static double dblDirectInc = 0;
        public static double dblDirectGDP = 0;
        public static double dblDirectOut = 0;
        public static double dblWages = 0;
        public static double? dblLocal = 0;
        public static double? dblState = 0;
        public static double? dblFederal = 0;
        public static double? dblTotalLocal = 0;
        public static double? dblTotalState = 0;
        public static double? dblTotalFederal = 0;
        public static double? dblFederalIns = 0;
        public static double? dblProfits = 0;
        public static double? dblTotalOut = 0;
        public static double? dblTotalEmp = 0;
        public static double? dblTotalInc = 0;
        public static double? dblTotalGDP = 0;
        public static double? dblInitialEffect = 0;
        public static double? dblP = 0;
        public static double? dblOutTotEff = 0;
        public static double? dblOutDirEff = 0;
        public static double? dblPersonalInc = 0;
        public String region_name { set; get; }//  regionname or all

        public void SetDefaultCategoryDistribution(int iTypeOfRehab1)
        {
            GeneralInfo x = repository.getfirstvaluogf_from_GeneralInfo();
            String propname = "";
            for (int i = 19; i < ELEMINR3; i++)
            {
                propname = "" + (i - 17);
                _nVectorSettings[REHABTHREE + (iTypeOfRehab1 * ELEMINR3) + i] = Convert.ToInt32(x[propname]);



            }
        }

        // large arrays that are used in multiregional computations
        public static double[, ,] dblMatrix = new double[SECTORS - 2, SECTORS - 2, NumberOfMultipleRegions]; //holds US AMatrix
        double[,] HugeMatrix = new double[NumberOfMultipleRegions * (SECTORS - 2), NumberOfMultipleRegions * (SECTORS - 2)];
        public void CalculationsThread()
        {

            int i;
            double dblTemp;


            dblDirectEmp = 0;
            dblDirectInc = 0;
            dblDirectGDP = 0;
            dblWages = 0;
            dblLocal = 0;
            dblState = 0;
            dblFederal = 0;
            dblFederalIns = 0;
            dblProfits = 0;
            dblTotalEmp = 0;
            dblTotalInc = 0;
            dblTotalGDP = 0;
            dblInitialEffect = 0;

            //Start of Calculations



            getActivities();

            //("Preparing Data");

            // Translating PC I/O into I/O
            TranslatePCIO();

            MultiplyPbyIO();

            //Main Street Retail Calculation takes place
            MainStreetRetailCalc();

            for (i = 0, dblTemp = 0; i < SECTORS; i++)
            {
                if (dblCalcVector[i] != 0)
                {
                    dblTemp += dblCalcVector[i] ?? default(double);
                }
            }

            for (i = 1, dblOutDirEff = 0; i < SECTORS - 2; i++)
            {
                if (dblCalcVector[i] != 0)
                {
                    dblOutDirEff += dblCalcVector[i];
                }
            }



            CalculateDirectEffect();

            //("Preparing Tables");
            // Multiplying by (I-A) inverse
            TransformIO();

            for (i = 0, dblTemp = 0; i < SECTORS; i++)  //sectors 519
            {
                if (dblCalcVector[i] != 0)
                {
                    //printf("%f, %f", i, dblCalcVector[i]);
                    dblTemp += dblCalcVector[i] ?? default(double);
                }
            }

            for (i = 1, dblOutTotEff = 0; i < SECTORS - 2; i++)
            {
                if (dblCalcVector[i] != 0)
                {
                    dblOutTotEff += dblCalcVector[i];
                }
            }



            // Writing into the database
            PrepareTempTables();


            //("Making Reports");

            // Preparing Report Tables

            PrepareOccupationalReport();



            PrepareReportTables();



            MyRecordset = null;
            RegRecordset = null;




        }
        void ValueDistribution(int tablename, double? total, int whre)
        {
            int PC_KEY = 0; //PC_KEY from rehab table
            double VALUE = 0; //VALUE from rehab table
            switch (tablename)
            {
                case 1://"newstoresandrestaurants":

                    MyRecordset = repository.getlistofnewstoresandrestaurants(); ///these mwthods return list<pckey,valu>

                    break;
                case 2://"fte":

                    MyRecordset = repository.getlistoffte();

                    break;
                case 3://"rehab":

                    MyRecordset = repository.getlistofrehaboncondition(whre); ///these mwthods return list<pckey,valu>
                    break;

                case 4://"daytrip":

                    MyRecordset = repository.getlistofdaytrip();
                    break;

                case 5://"camping":

                    MyRecordset = repository.getlistofrehabcamping();
                    break;
                case 6:// "lodging":

                    MyRecordset = repository.getlistoflodging();
                    break;
                case 7://"friendsandfamily":

                    MyRecordset = repository.getlistfriendsandfamily();
                    break;
                case 8://"mtherest":

                    MyRecordset = repository.getlistofMTHREST();
                    break;
                case 9://"mtourism":

                    MyRecordset = repository.getlistofmtourism();
                    break;
                case 10: //"mcapital":

                    MyRecordset = repository.getlistofmcapital();
                    break;
            }
            //MyRecordset->Open(dbOpenDynaset,strSQL,dbConsistent);

            // Loading the data

            //if (MyRecordset->GetRecordCount() > 0) MyRecordset->MoveFirst();
            //foreach(var element in myrecordset)
            //{
            //    PC_KEY = element["PC_KEY"]; //gets PC_KEY from Day Trip table
            //    VALUE = element["VALUE"];

            //}




            foreach (var xx in MyRecordset)
            {
                var pc_key_local = (xx.PC_KEY.Value);
                var value_local = xx.VALUE;
                if (pc_key_local == SECTORS - 2 || pc_key_local == SECTORS - 1)
                {

                    if (PC_KEY == SECTORS - 2)
                    {
                        dblLocal += total * value_local;
                        dblState += total * value_local;
                    }
                    else
                        dblFederal += total * value_local;
                    dblInitialEffect += total * value_local;
                }
                else
                {

                    this.dblCalcVector[pc_key_local] += total * xx.VALUE;  //make sure before this this list intialised and here updating values

                }
            }
            double test = 0;
            for (int i = 0; i < SECTORS; i++)
                test = test + (dblCalcVector[i] ?? 0.0);


        }
        public void MainStreetCalc()
        {
            //New Construciton Calculation
            if (_nVectorSettings[ISMS] == 1)  //19th place in settings
            {
                //ValueDistribution("SELECT * FROM [New Stores and Restaurants];", 
                //    _nVectorSettings[MAINSTREET + 2], dblCalcVector);
                ValueDistribution(1, _nVectorSettings[MAINSTREET + 2], 0);  //sending seeting 3rd value
                // case 1://"newstoresandrestaurants":
            }
            double? dblTemp = 0;
            for (int i = 0; i < SECTORS; i++) //all sectors=519 recod total multilpled  values sum
                dblTemp = dblTemp + dblCalcVector[i];

            //FTE Calculations
            double? dblFTE = 0;
            dblFTE = repository.getfirstvaluogfDollarsPerFTE_from_GeneralInfo();

            if (_nVectorSettings[ISMS] == 1)
            {  //19th place in settings
                double? gg = 0;

                gg = (_nVectorSettings[MAINSTREET] * dblFTE);
                ValueDistribution(2, gg, 0);   //sending seeting 1st value*ftevalu
                // case  2://"fte":

            }

            //Rehab Calculation 
            if (_nVectorSettings[ISMS] == 1 && _nVectorSettings[ISRH] == 0)
            {  //isrh(22)=general(19)+3

                double[] dblDistrib = new double[18];
                double[] dblLaborDist = new double[18];

                dblDistrib = repository.getlistof1to17columnsvaluesin160row_Distribution(); //if soft cost included change 160 to 128
                //trSQL = "SELECT * FROM Distribution WHERE ID = 160;"; //if soft cost included change 160 to 128


                double count = 0;

                for (int i = 0; i < 18; i++)
                {

                    count += dblDistrib[i];
                }

                dblLaborDist = repository.getlistofcolumnnameis0to17columnsvaluesfrom_GeneralInfo();


                for (int i = 0; i < 18; i++)
                    dblLaborDist[i] = dblLaborDist[i] / 100;


                String whre = "";
                int whret = 0;
                string whrel = "";
                for (int j = 0; j < 2; j++)
                {//two times 0,1
                    for (int k = 0; k < 18; k++)
                    {
                        double dblTotal = _nVectorSettings[MAINSTREET + 3] * dblDistrib[k]; // settings4thvalu* distributiontable allcomun(listof1to17columns)valuesin160row_Distribution
                        double dblPercent = dblLaborDist[k];

                        if (j == 1) { dblPercent = 1 - dblPercent; }
                        whret = j + 1;
                        if (k < 10)
                            whrel = "0";
                        else
                            whrel = "";
                        whre = "" + 3 + "" + (j + 1) + "" + whrel + k;
                        whret = Convert.ToInt32(whre);
                        ValueDistribution(3, dblTotal * dblPercent, whret);
                        // case  3 ://"rehab":
                    }
                }
            }
            //double dblTemp=0;
            for (int i = 0; i < SECTORS; i++)
                dblTemp += dblCalcVector[i];

            int tee = 0;
        }

        void MainStreetRetailCalc()
        {
            if (_nVectorSettings[TEMP] == 0 || _nVectorSettings[TEMP] == 4) //temp=0 meansif first setting valu 0 or 4
            {
                int ID = 0;
                int te = 0;
                List<JointVenture> joinventur = repository.getlistofidandvalue_JointVentures(); //should retrun a list<int,float>
                foreach (var x in joinventur)
                {
                    te = (int)x.VALUE;
                    dblCalcVector[x.ID ?? default(int)] = dblCalcVector[x.ID ?? default(int)] + x.VALUE * _nVectorSettings[MAINSTREET + 1];
                    //add something moreto existing values the existing values  in the given locations
                }


                dblInitialEffect += _nVectorSettings[MAINSTREET + 1]; //increase effect value value in 2nd setting value
            }
        }

        void RehabCalc()
        {
            if (_nVectorSettings[ISRH] == 1)   //isrh(22)=general(19)+3   
            {
                double dblLaborAt0 = 0; //percentage that went to labor at field zero
                double dblLaborAt1 = 0; //percentage that went to labor at field one
                double dblLaborAt17 = 0; //percentage that went to labor at field seventeen
                int iPC_KEY = 0; //PC_KEY from rehab table
                double dVALUE = 0; //VALUE from rehab table

                GeneralInfo GI = repository.getfirstvaluogf_from_GeneralInfo();  //this ib not from 1 but from 0-17

                dblLaborAt0 = GI.C0 ?? default(double);
                dblLaborAt1 = GI.C1 ?? default(double);
                dblLaborAt17 = GI.C17 ?? default(double);

                String whre = "";
                int whret = 0;
                int whret2 = 0;
                string whrel = "";
                for (int i = 0; i < 4; i++)
                {
                    if (_nVectorSettings[REHABONE + i] == 1)
                    { //rehabone is 23rd setting
                        for (int j = 0; j < 2; j++)
                        {
                            for (int k = 0; k < 18; k++)
                            {
                                double dblTotal = _nVectorSettings[REHABTHREE + i * ELEMINR3 + 18] * _nVectorSettings[REHABTHREE + i * ELEMINR3 + k] / 100;
                                double dblPercent = 0;
                                switch (k)
                                {
                                    case 0: dblPercent = dblLaborAt0; break;
                                    case 1: dblPercent = dblLaborAt1; break;
                                    case 17: dblPercent = dblLaborAt17; break;
                                    default: dblPercent = _nVectorSettings[REHABTHREE + i * ELEMINR3 + 19 + k - 2]; break;
                                }
                                dblPercent /= 100;
                                if (j == 1)
                                { dblPercent = 1 - dblPercent; }
                                //whret=j+1;
                                //whret2=i+1;
                                //if (k<10)
                                //    whrel="0";
                                //else
                                //    whrel=""+k;
                                //whre=""+whret2+""+ whret+whrel;
                                //whret = Convert.ToInt32(whre);

                                //rehabtree 31  eleminr is 34		


                                if (k < 10)
                                    whrel = "0";
                                else
                                    whrel = "";
                                whre = "" + (i + 1) + "" + (j + 1) + "" + whrel + k;
                                whret = Convert.ToInt32(whre);

                                ValueDistribution(3, dblTotal * dblPercent, whret);
                                // case  3 ://"rehab":
                            }
                        }
                    }
                }
            }
        }

        void TourismCalc()
        {
            if (_nVectorSettings[IST] == 1)  //general 19   tourism=5  ist =19+2
            {
                if (_nVectorSettings[TOURISM] == 1)  //checks if Day Trip checkbox was checked
                {
                    ValueDistribution(4, _nVectorSettings[TOURISM + 8] * _nVectorSettings[TOURISM + 9], 0);
                    //case 4://"daytrip":

                }

                if (_nVectorSettings[TOURISM + 1] == 1)  //checks if Night Trip checkbox was checked
                {
                    //Camping Calculation
                    ValueDistribution(5, _nVectorSettings[TOURISM + 10] * _nVectorSettings[TOURISM + 2] * _nVectorSettings[TOURISM + 3] / 100, 0);
                    // case 5://"camping":
                    //Lodging Calculation
                    ValueDistribution(6,
                        _nVectorSettings[TOURISM + 10] * _nVectorSettings[TOURISM + 4]
                            * _nVectorSettings[TOURISM + 5] / 100, 0);

                    // case 6:// "lodging":

                    //Friends And Family Calculation
                    ValueDistribution(7,
                        _nVectorSettings[TOURISM + 10] * _nVectorSettings[TOURISM + 6]
                            * _nVectorSettings[TOURISM + 7] / 100, 0);

                    // case 7://"friendsandfamily":
                }
            }
        }

        void MuseumsCalc()
        {
            GeneralInfo gobj = repository.getfirstvaluogf_from_GeneralInfo();
            double visitors = gobj.visitors ?? default(double);
            double capital = gobj.capital ?? default(double);
            double rest = gobj.rest ?? default(double);
            double RCRatio = gobj.RCRatio ?? default(double);
            double RVRatio = gobj.RVRatio ?? default(double);


            if (_nVectorSettings[ISM] == 1 && (int)_nVectorSettings[TEMP] == 1)  //temp=0 ism=general+1 ist=genral+2  general=19 
            {
                if ((_nVectorSettings[IST] == 1) && (_nVectorSettings[ISRH] == 1)) //all three fields
                {
                    //The Rest Calculation
                    ValueDistribution(8,
                        (_nVectorSettings[MUSEUM] - _nVectorSettings[MUSEUM + 1]
                            - _nVectorSettings[MUSEUM + 2]), 0);
                    // case 8://"mtherest":
                    //Visitors Calculation
                    ValueDistribution(9,
                        _nVectorSettings[MUSEUM + 1], 0);
                    // case 9://"mtourism":
                    //Capital Calculation
                    ValueDistribution(10,
                        _nVectorSettings[MUSEUM + 2], 0);
                    // case 10: //"mcapital":
                }
                if ((_nVectorSettings[IST] == 1) && (_nVectorSettings[ISRH] != 1)) //only anual and visitors
                {
                    //Visitors Calculation
                    ValueDistribution(9,
                        _nVectorSettings[MUSEUM + 1], 0);
                    // case 9://"mtourism":
                    //Capital Calculation
                    ValueDistribution(10,
                        (_nVectorSettings[MUSEUM] - _nVectorSettings[MUSEUM + 1]) / (RCRatio + 1), 0);
                    // case 10: //"mcapital":
                    //The Rest Calculation
                    ValueDistribution(8,
                        (_nVectorSettings[MUSEUM] - _nVectorSettings[MUSEUM + 1]) / (RCRatio + 1) * RCRatio, 0);
                    // case 8://"mtherest":
                }
                if ((_nVectorSettings[IST] != 1) && (_nVectorSettings[ISRH] == 1)) //only anual and capital
                {
                    //Capital Calculation
                    ValueDistribution(10,
                        _nVectorSettings[MUSEUM + 2], 0);
                    // case 10: //"mcapital":

                    //Visitors Calculation
                    ValueDistribution(9,
                        (_nVectorSettings[MUSEUM] - _nVectorSettings[MUSEUM + 2]) / (RVRatio + 1), 0);
                    //case 9://"mtourism":
                    //The Rest Calculation
                    ValueDistribution(8,
                        (_nVectorSettings[MUSEUM] - _nVectorSettings[MUSEUM + 2]) / (RVRatio + 1) * RVRatio, 0);
                    // case 8://"mtherest":
                }
                if ((_nVectorSettings[IST] != 1) && (_nVectorSettings[ISRH] != 1)) //only anual
                {
                    //The Rest Calculation
                    ValueDistribution(8,
                        _nVectorSettings[MUSEUM] * rest, 0);  // case 8://"mtherest":
                    //Visitors Calculation
                    ValueDistribution(9,
                        _nVectorSettings[MUSEUM] * visitors, 0);  //case 9://"mtourism":
                    //Capital Calculation
                    ValueDistribution(10,
                        _nVectorSettings[MUSEUM] * capital, 0);  //case 10: //"mcapital":
                }
            }

            if (_nVectorSettings[ISM] == 1 && (int)_nVectorSettings[TEMP] == 4)
            {
                if ((_nVectorSettings[IST] == 1) && (_nVectorSettings[ISRH] == 1)) //all three fields
                {
                    //The Rest Calculation
                    ValueDistribution(8,
                        (_nVectorSettings[MUSEUM] - _nVectorSettings[MUSEUM + 1]
                            - _nVectorSettings[MUSEUM + 2]), 0);
                    // case 8://"mtherest":
                    //Visitors Calculation
                    //			ValueDistribution("SELECT * FROM MTourism;", 
                    //				_nVectorSettings[MUSEUM + 1], dblCalcVector);
                    //Capital Calculation
                    //			ValueDistribution("SELECT * FROM MCapital;", 
                    //				_nVectorSettings[MUSEUM + 2], dblCalcVector);
                }
                if ((_nVectorSettings[IST] == 1) && (_nVectorSettings[ISRH] != 1)) //only anual and visitors
                {
                    //Visitors Calculation
                    //			ValueDistribution("SELECT * FROM MTourism;", 
                    //				_nVectorSettings[MUSEUM + 1], dblCalcVector);
                    //Capital Calculation
                    //			ValueDistribution("SELECT * FROM MCapital;", 
                    //				(_nVectorSettings[MUSEUM] - _nVectorSettings[MUSEUM + 1]) / (RCRatio + 1), dblCalcVector);
                    //The Rest Calculation
                    ValueDistribution(8,
                        (_nVectorSettings[MUSEUM] - _nVectorSettings[MUSEUM + 1]) / (RCRatio + 1) * RCRatio, 0);
                    // case 8://"mtherest":
                }
                if ((_nVectorSettings[IST] != 1) && (_nVectorSettings[ISRH] == 1)) //only anual and capital
                {
                    //Capital Calculation
                    //			ValueDistribution("SELECT * FROM MCapital;", 
                    //				_nVectorSettings[MUSEUM + 2], dblCalcVector);
                    //Visitors Calculation
                    //			ValueDistribution("SELECT * FROM MTourism;", 
                    //				(_nVectorSettings[MUSEUM] - _nVectorSettings[MUSEUM + 2]) / (RVRatio + 1), dblCalcVector);
                    //The Rest Calculation
                    ValueDistribution(8,
                        (_nVectorSettings[MUSEUM] - _nVectorSettings[MUSEUM + 2]) / (RVRatio + 1) * RVRatio, 0);
                    // case 8://"mtherest":
                }
                if ((_nVectorSettings[IST] != 1) && (_nVectorSettings[ISRH] != 1)) //only anual
                {
                    //The Rest Calculation
                    ValueDistribution(8,
                        _nVectorSettings[MUSEUM] * rest, 0);
                    // case 8://"mtherest":
                    //Visitors Calculation
                    //			ValueDistribution("SELECT * FROM MTourism;", 
                    //				_nVectorSettings[MUSEUM] * visitors, dblCalcVector);
                    //Capital Calculation
                    //			ValueDistribution("SELECT * FROM MCapital;", 
                    //				_nVectorSettings[MUSEUM] * capital, dblCalcVector);
                }
            }
        }

        // Translates PC I/O's into I/O's
        void TranslatePCIO()
        {
            double?[] dblTemp = new double?[SECTORS]; //total 519 values


            for (int i = 0; i < SECTORS; i++)
                dblTemp[i] = 0;





            List<ZNewIoCode> iocode_id_and_keyfound = null;
            int y = 0;
            int ll = 0;
            for (int i = 0; i < SECTORS; i++)
            {
                if (dblCalcVector[i] != 0)
                {
                    iocode_id_and_keyfound = repository.getiocode_id_and_keyfound(i);
                    foreach (var xx in iocode_id_and_keyfound)
                    {

                        ll = xx.ID;
                        dblTemp[ll] = dblCalcVector[i] / xx.PC_KEY_FOUND;

                    }

                }


            }





            //dblInitialEffect = 0;
            for (int i = 0; i < SECTORS; i++)
            {
                dblCalcVector[i] = dblTemp[i];
                dblInitialEffect += dblCalcVector[i];
            }

            int hhhh = 0;
        }

        //MULTIPLYING P by IO
        void MultiplyPbyIO()
        {
            string regionname = region_name;
            List<regionclassp> riop = null;
            riop = repository.getRIOandp_orderbyRIO_from_defaultdata(regionname);//this is Data from selected region

            //strSQL	= "SELECT RIO, P FROM DefaultData ORDER BY RIO;";


            if (riop.Count > 0)
            {
                //RegRecordset->MoveLast();
                int i = 0;
                //int intDim = (int)(Utils::GetDoubleValue(RegRecordset, 0));

                double testemp = 0;
                foreach (var x in riop)
                {
                    dblCalcVector[i + 1] = dblCalcVector[i + 1] * x.p;
                    testemp = testemp + (dblCalcVector[i + 1] ?? 0.0);

                    i = i + 1;
                }
                testemp = testemp + 1;
            }
        }


        // Multiplies IO's by inv(I-A)
        void TransformIO()
        {
            string regionname = region_name;
            double[] dblTemp = new double[SECTORS];
            double? dblResult;
            List<LeontievInversegeneric> li;
            for (int i = 0; i < SECTORS; i++)
                dblTemp[i] = 0;
            li = repository.getalldatafor_LeontievInverse(regionname);//exist in few tables of region

            //strSQL	= "SELECT * FROM LeontievInverse;";


            if (li != null)
            {


                int? intDim2 = li[li.Count - 1].ID; // get id of  last record in list
                double intDim1 = intDim2 ?? 0.0;
                intDim1 = Math.Sqrt(intDim1);
                int intDim = (int)intDim1;

                int position = 0;
                // int ii=0;
                for (int ii = 0; ii < intDim; ii++)
                {
                    dblResult = 0;

                    for (int j = 0; j < intDim; j++)
                    {
                        dblResult += dblCalcVector[j + 1] * li[position].VALUE;
                        position++;

                    }
                    if (ii < SECTORS - 1)
                        dblTemp[ii + 1] = dblResult ?? default(double);


                }

                for (int i = 0; i < SECTORS; i++)
                    dblCalcVector[i] = dblTemp[i];
            }


        }

        public double[] CrossMultiply(String strSQL, ref double[] tempdblVector)
        {
            //requeste below
            //CrossMultiply("SELECT RIO, Inc FROM DefaultData;", dblTempInc, RegRecordset);
            //CrossMultiply("SELECT RIO, Emp FROM DefaultData;", dblTempEmp, RegRecordset);
            //CrossMultiply("SELECT RIO, GDP FROM DefaultData;", dblTempGDP, RegRecordset);
            string regionname = region_name;
            double[,] orgianl = new double[SECTORS, SECTORS];
            if (strSQL == "Inc")
            {
                orgianl = repository.getdefaultdataon_rio_inc(regionname);//SELECT RIO, Inc FROM DefaultData but  dont retrun as object
            }
            if (strSQL == "Emp")
            {
                orgianl = repository.getdefaultdataon_rio_emp(regionname); //SELECT RIO, Emp FROM DefaultData;
            }
            if (strSQL == "GDP")
            {
                orgianl = repository.getdefaultdataon_rio_gdp(regionname); //SELECT RIO, GDP FROM DefaultData;"
            }


            //int i=0;

            for (int i = 1; i < SECTORS; i++)
            {
                if (tempdblVector[i] != 0)
                    tempdblVector[i] *= orgianl[i - 1, 1];

            }

            return tempdblVector;
        }

        void WriteToDB(double[] dblOut, double[] dblInc, double[] dblEmp, double[] dblGDP)
        {
            //repository.deleteallrecordsfromtbltemp();
            tbltemp = new List<tblTemp>();



            for (int i = 0; i < SECTORS; i++)
            {
                if ((dblOut[i] + dblInc[i] + dblEmp[i] + dblGDP[i]) != 0)
                {
                    tbltemp.Add(new tblTemp(ID: i, Output: dblOut[i] / 1000, Income: dblInc[i] / 1000, Employment: dblEmp[i] / 1000, GDP: dblGDP[i] / 1000));
                }
            }
        }



        double DirectEffect(String col)
        {
            //loc and tempdefault  refers regional data of directeffect
            //but pnations data also stored in loc
            //somepther set refers general data
            string regionname = region_name;
            double[] dblTwoDigitInd = new double[SICSECTORS]; //modifed
            for (int i = 0; i < SICSECTORS; i++)
            {
                dblTwoDigitInd[i] = 0;
            }

            //4 parameters   here dblTwoDigitInd is empty
            //DirectEffect(col, strSQL, recordset, dblCalcVector, dblTwoDigitInd); //recordset=MyRecordset(OR)RegRecordset
            //dblDirectOut = DirectEffect("Output", "SELECT * FROM [P(nation)];", MyRecordset, dblCalcVector); // P(nation) contains all 1s
            //dblDirectEmp = DirectEffect("Employment", "SELECT RIO, Emp FROM DefaultData ORDER BY RIO;", RegRecordset, dblCalcVector);
            //dblDirectInc = DirectEffect("Income", "SELECT RIO, Inc FROM DefaultData ORDER BY RIO;", RegRecordset, dblCalcVector);
            //dblDirectGDP = DirectEffect("GrossStateProduct", "SELECT RIO, GDP FROM DefaultData ORDER BY RIO;", RegRecordset, dblCalcVector);

            //only first time MyRecordset recomes recordset and othercases RegRecordset-- becomes recordset
            // RegRecordset-- becomes recordset
            //dblCalcVector  becomes same dblCalcVector

            int SIC = 0;
            double dblEffect = 0;
            List<tempclass> loc = new List<tempclass>(); //temp class  with 2 columns..wht datw we get reassign it backot this
            List<generic_DefaultData> tempdefault = new List<generic_DefaultData>();

            if (col == "Output")
                loc = repository.getidandpfrompnationasfirstsecond(); // this is without region sELECT *(id,p) FROM [P(nation)]
            if (col == "Employment")
            {
                tempdefault = repository.getdefaultrecords(regionname); //RegRecordset  from DirectEffect("Employment", "SELECT RIO, Emp FROM DefaultData ORDER BY RIO;", RegRecordset,
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.Emp }).OrderBy(x => x.first).ToList();
            }
            // loc=repository.getrioandempfromDefaultDatafirstsecond(); //SELECT RIO, Emp FROM DefaultData ORDER BY RIO;
            if (col == "Income")
            {
                tempdefault = repository.getdefaultrecords(regionname);
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.Inc }).OrderBy(x => x.first).ToList();
            }
            // loc=repository.getrioandincomefromDefaultDatafirstsecond(); //SELECT RIO, Inc FROM DefaultData ORDER BY RIO
            if (col == "GrossStateProduct")
            {
                tempdefault = repository.getdefaultrecords(regionname);
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.GDP }).OrderBy(x => x.first).ToList();
            }
            //loc=repository.getrioandgspfromDefaultDatafirstsecond(); //SELECT RIO, GDP FROM DefaultData ORDER BY RIO;"

            //dblWages = DirectEffect("SELECT RIO, Wages FROM DefaultData;", RegRecordset, dblCalcVector);
            //dblTotalState = DirectEffect("SELECT RIO, State FROM DefaultData;", RegRecordset, dblCalcVector);
            //dblTotalLocal = DirectEffect("SELECT RIO, Local FROM DefaultData;", RegRecordset, dblCalcVector);
            //dblTotalFederal = DirectEffect("SELECT RIO, FederalGen FROM DefaultData;", RegRecordset, dblCalcVector);
            //dblState = BusinessDirectEffect("SELECT RIO, State FROM DefaultData;", RegRecordset, dblCalcVector);
            //dblLocal = BusinessDirectEffect("SELECT RIO, Local FROM DefaultData;", RegRecordset, dblCalcVector);
            //dblFederal = BusinessDirectEffect("SELECT RIO, FederalGen FROM DefaultData;", RegRecordset, dblCalcVector);
            //dblFederalIns = DirectEffect("SELECT RIO, FederalIns FROM DefaultData;", RegRecordset, dblCalcVector);
            // RegRecordset-- becomes recordset
            //dblCalcVector  becomes same dblCalcVector
            //DirectEffect(                    CString strSQL, CDaoRecordset* recordset, double dblCalcVector[])
            //DirectEffect("",                strSQL,        recordset, dblCalcVector, dblTwoDigitInd);  /dblTwoDigitInd is empty
            //DirectEffect(CString strColumn, CString strSQL, CDaoRecordset* recordset, double dblCalcVector[], double dblTwoDigitInd[]) 
            if (col == "wages")
            {
                tempdefault = repository.getdefaultrecordsnoorder(regionname);
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.Wages }).ToList();
            }
            //  loc=repository.getrioandwagesfromDefaultDatafirstsecond(); //SSELECT RIO, Wages FROM DefaultData;
            if (col == "state")
            {
                tempdefault = repository.getdefaultrecordsnoorder(regionname);
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.State }).ToList();
            } //SELECT RIO, state FROM DefaultData;
            if (col == "local")
            {
                tempdefault = repository.getdefaultrecordsnoorder(regionname);
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.Local }).ToList();
            }//SELECT RIO, local FROM DefaultData;
            if (col == "federalgen")
            {
                tempdefault = repository.getdefaultrecordsnoorder(regionname);
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.FederalGen }).ToList();
            }//SELECT RIO, federalgen FROM DefaultData;
            if (col == "federalins")
            {
                tempdefault = repository.getdefaultrecordsnoorder(regionname);
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.FederalIns }).ToList();
            }//SELECT RIO, federalins FROM DefaultData;
            //SELECT * FROM [I/O Codes] WHERE [I/O Codes].ID =1 to sectors  as sometherset
            //NED TO WORK AGIN
            //I chnages select id,sic from FROM [I/O Codes] WHERE [I/O Codes].ID =1 to sectors  as sometherset
            List<tempclass> sometherset = new List<tempclass>();
            List<ZNewIoCode> someotherse1t = null;
            double d = 0;
            for (int i = 1; (i < SECTORS) && (i <= loc.Count()); i++)
            {
                if (dblCalcVector[i] != 0)
                {
                    dblEffect += dblCalcVector[i] * loc[i - 1].second ?? default(double);  // test loc[i].first=Utils::GetDoubleValue(recordset, 1);
                    if (col == "Output" || col == "Employment" || col == "Income" || col == "GrossStateProduct")
                    {   //strSQL = "SELECT * FROM [I/O Codes] WHERE [I/O Codes].ID = " + Utils::IntToString(i) 
                        someotherse1t = repository.getiocode_id_and_keyfound(i);
                        sometherset = someotherse1t.Select(x => new tempclass { first = x.ID, second = x.SIC }).OrderBy(x => x.first).ToList();

                        if (sometherset != null && sometherset.Count > 0)
                        {
                            d = sometherset[0].second ?? default(double);   //which is SIC 
                            SIC = (int)(d);
                            dblTwoDigitInd[SIC] += (dblCalcVector[i] * loc[i].second) ?? default(double);
                        }
                    }

                }
            }
            //******************fill table code also written here only    instead of checking strcol!="" checking possible 4 values output employment income gsp
            //th reason for above changeis to fit all direct effects with easy implimentaion
            int sici = 0;
            if (col == "Output")
            {
                foreach (var v in tblDirectEffects)
                {
                    sici = v.SIC ?? default(int);
                    v.Output = dblTwoDigitInd[sici] / 1000;


                }
            }//repository.updatetblDirectEffects_outputcolumnwithvaluesavedbysicindexindblTwoDigitInd();// here we 


            //will  fisrs record sic value.ex:4.and then directeffectable.output=towdigitind[4]/1000; 
            if (col == "Employment")
            {
                foreach (var v in tblDirectEffects)
                {
                    sici = v.SIC ?? default(int);
                    v.Employment = dblTwoDigitInd[sici] / 1000;


                }
            }
            if (col == "Income")
            {
                foreach (var v in tblDirectEffects)
                {
                    sici = v.SIC ?? default(int);
                    v.Income = dblTwoDigitInd[sici] / 1000;


                }
            }
            if (col == "GrossStateProduct")
            {
                foreach (var v in tblDirectEffects)
                {
                    sici = v.SIC ?? default(int);
                    v.GrossStateProduct = dblTwoDigitInd[sici] / 1000;


                }
            }


            return dblEffect;
        }


        double BusinessDirectEffect(String strSQL)
        {
            region_name = region_name;
            double dblEffect = 0;

            List<tempclass> loc = new List<tempclass>(); //temp class  with 2 columns..wht datw we get reassign it backot this
            List<generic_DefaultData> tempdefault = new List<generic_DefaultData>();

            if (strSQL == "state")
            {
                tempdefault = repository.getdefaultrecordsnoorder(region_name);
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.State }).ToList();
            } //SELECT RIO, state FROM DefaultData;

            if (strSQL == "local")
            {
                tempdefault = repository.getdefaultrecordsnoorder(region_name);
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.Local }).ToList();
            } //SELECT RIO, state FROM DefaultData;

            if (strSQL == "federalgen")
            {
                tempdefault = repository.getdefaultrecordsnoorder(region_name);
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.FederalGen }).ToList();
            } //SELECT RIO, state FROM DefaultData;

            for (int i = 1; (i < SECTORS - 2) && (i <= loc.Count()); i++)
            {
                if (dblCalcVector[i] != 0)
                    dblEffect += dblCalcVector[i] * (loc[i - 1].second) ?? default(double);

            }

            return dblEffect;
        }

        void CalculateDirectEffect()
        {

            // List<tblDirectEffects> tde= repository.getallfromtblDirectEffects();
            tblDirectEffects = new List<tblDirectEffect>();
            //make all  below values zero
            foreach (var t in tblDirectEffects)
            {
                t.Output = 0;
                t.Employment = 0;
                t.Income = 0;
                t.GrossStateProduct = 0;
            }

            dblDirectOut = DirectEffect("Output"); // P(nation) contains all 1s
            dblDirectEmp = DirectEffect("Employment");
            dblDirectInc = DirectEffect("Income");
            dblDirectGDP = DirectEffect("GrossStateProduct");

            //	dblDirectOut = DirectEffect("Output", "SELECT * FROM [P(nation)];", MyRecordset, dblCalcVector); // P(nation) contains all 1s
            //dblDirectEmp = DirectEffect("Employment", "SELECT RIO, Emp FROM DefaultData ORDER BY RIO;", RegRecordset, dblCalcVector);
            //dblDirectInc = DirectEffect("Income", "SELECT RIO, Inc FROM DefaultData ORDER BY RIO;", RegRecordset, dblCalcVector);
            //dblDirectGDP = DirectEffect("GrossStateProduct", "SELECT RIO, GDP FROM DefaultData ORDER BY RIO;"

        }

        void PrepareTempTables()
        {
            double[] dblTempOut = new double[SECTORS];
            double[] dblTempInc = new double[SECTORS];
            double[] dblTempEmp = new double[SECTORS];
            double[] dblTempGDP = new double[SECTORS];

            for (int i = 0; i < SECTORS; i++)
            {
                dblTempOut[i] = dblTempInc[i] = dblTempEmp[i] = dblTempGDP[i] = (dblCalcVector[i] ?? default(double));
            }
            //CrossMultiply("SELECT RIO, Inc FROM DefaultData;", dblTempInc, RegRecordset);
            //CrossMultiply("SELECT RIO, Emp FROM DefaultData;", dblTempEmp, RegRecordset);
            //CrossMultiply("SELECT RIO, GDP FROM DefaultData;", dblTempGDP, RegRecordset);
            dblTempInc = CrossMultiply("Inc", ref  dblTempInc);
            dblTempEmp = CrossMultiply("Emp", ref dblTempEmp);
            dblTempGDP = CrossMultiply("GDP", ref  dblTempGDP);

            WriteToDB(dblTempOut, dblTempInc, dblTempEmp, dblTempGDP);  //to fill tbltemp table 4 coloms to db
            // here List<tblTemp>();
            for (int i = 0; i < SECTORS; i++)
            {
                dblTotalOut += dblTempOut[i];
                dblTotalEmp += dblTempEmp[i];
                dblTotalInc += dblTempInc[i];
                dblTotalGDP += dblTempGDP[i];
            }

            dblWages = DirectEffect("wages");
            dblTotalState = DirectEffect("state");
            dblTotalLocal = DirectEffect("local");
            dblTotalFederal = DirectEffect("federalgen");
            dblState = BusinessDirectEffect("state");
            dblLocal = BusinessDirectEffect("local");
            dblFederal = BusinessDirectEffect("federalgen");
            dblFederalIns = DirectEffect("federalins");
        }

        void GeneralIndustryData(int SIC, int sector, ref double[,] dblGIndustry, ref double[,] dblTemp)
        {
            dblGIndustry[sector, 0] += dblTemp[SIC, 0]; //Employment
            dblGIndustry[sector, 1] += dblTemp[SIC, 1]; //Income
            dblGIndustry[sector, 2] += dblTemp[SIC, 2]; //GDP
            dblGIndustry[sector, 3] += dblTemp[SIC, 3]; //Output
        }


        double[] getBase(String strSQL)
        {

            List<tempclass> loc = new List<tempclass>(); //temp class  with 2 columns..wht datw we get reassign it backot this
            List<generic_DefaultData> tempdefault = new List<generic_DefaultData>();

            if (strSQL == "supply")
            {
                tempdefault = repository.getdefaultrecords(region_name);
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.Supply }).OrderBy(x => x.first).ToList();
            }
            if (strSQL == "inc")
            {
                tempdefault = repository.getdefaultrecords(region_name);
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.Inc }).OrderBy(x => x.first).ToList();
            }
            if (strSQL == "gdp")
            {
                tempdefault = repository.getdefaultrecords(region_name);
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.GDP }).OrderBy(x => x.first).ToList();
            }
            if (strSQL == "emp")
            {
                tempdefault = repository.getdefaultrecords(region_name);
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.Emp }).OrderBy(x => x.first).ToList();
            }
            //getBase("SELECT RIO, Supply FROM DefaultData ORDER BY RIO;", dblSupplyTotal);

            int i = 1;
            double[] dblVector_1 = new double[SECTORS];
            for (int t = 0; t < SECTORS; t++)
            {
                dblVector_1[t] = 0;

            }
            foreach (var v in loc)
            {
                if (i < SECTORS - 2)
                    dblVector_1[i] = dblVector_1[i] + (v.second ?? default(double));
                i++;
            }
            return dblVector_1;
        }

        double[] getBase(String strSQL, double[] dblVector1, double[] dblVector2)
        {

            List<tempclass> loc = new List<tempclass>(); //temp class  with 2 columns..wht datw we get reassign it backot this
            List<generic_DefaultData> tempdefault = new List<generic_DefaultData>();

            if (strSQL == "supply")
            {
                tempdefault = repository.getdefaultrecords(region_name);
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.Supply }).OrderBy(x => x.first).ToList();
            }
            if (strSQL == "inc")
            {
                tempdefault = repository.getdefaultrecords(region_name);
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.Inc }).OrderBy(x => x.first).ToList();
            }
            if (strSQL == "gdp")
            {
                tempdefault = repository.getdefaultrecords(region_name);
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.GDP }).OrderBy(x => x.first).ToList();
            }
            if (strSQL == "emp")
            {
                tempdefault = repository.getdefaultrecords(region_name);
                loc = tempdefault.Select(x => new tempclass { first = x.RIO, second = x.Emp }).OrderBy(x => x.first).ToList();
            }
            //getBase("SELECT RIO, Supply FROM DefaultData ORDER BY RIO;", dblSupplyTotal);


            int i = 1;
            foreach (var v in loc)
            {
                if (i < SECTORS - 2)
                    dblVector1[i] = dblVector1[i] + dblVector2[i] * (v.second ?? default(double));
                i++;
            }
            return dblVector1;

        }


        void PrepareReport(ref double[,] dblTemp, ref double[,] dblGIndustry)
        {
            int iSIC = 0;
            for (int i = 0; i < SICSECTORS; i++)
                for (int j = 0; j < 4; j++)
                    dblTemp[i, j] = 0;   //is local  dbltemp  and global means db table is  tbltemp

            for (int i = 0; i < 12; i++)
                for (int j = 0; j < 4; j++)
                    dblGIndustry[i, j] = 0;

            List<ZNewIoCode> iodata = repository.getiocode_id_and_keyfound();
            List<joinedcalss> loc = (from pd in iodata
                                     join od in tbltemp on pd.ID equals od.ID
                                     orderby pd.ID
                                     select new joinedcalss
                                     {
                                         Employment = od.Employment,
                                         ID = od.ID,
                                         SIC = pd.SIC,
                                         GDP = od.GDP,
                                         Income = od.Income,
                                         Output = od.Output


                                     }).ToList();

            //temp class  with 2 columns..wht datw we get reassign it backot this
            //   column6class  comes using "SELECT [I/O Codes].SIC, tblTemp.ID, tblTemp.Income, tblTemp.Employment, tblTemp.GDP, tblTemp.Output " + 
            //"FROM [I/O Codes] RIGHT JOIN tblTemp ON [I/O Codes].ID = tblTemp.ID ORDER BY [I/O Codes].ID;", 


            // Loading the data

            foreach (var p in loc)
            {
                iSIC = p.SIC ?? default(int);
                dblTemp[iSIC, 0] += p.Employment ?? default(double);
                dblTemp[iSIC, 1] += p.Income ?? default(double);
                dblTemp[iSIC, 2] += p.GDP ?? default(double);
                dblTemp[iSIC, 3] += p.Output ?? default(double);
                if ((p.ID) == SECTORS - 2)
                    dblPersonalInc = p.Output ?? default(double);


            }


            for (int i = 0; i < SICSECTORS; i++)
            {
                //General Industry data extraction
                if (i >= 11 && i <= 62) GeneralIndustryData(i, 1, ref dblGIndustry, ref dblTemp); //Agriculture
                if (i >= 70 && i <= 90) GeneralIndustryData(i, 2, ref dblGIndustry, ref dblTemp); //Forestry & Fish
                if (i >= 100 && i <= 140) GeneralIndustryData(i, 3, ref dblGIndustry, ref dblTemp); //Mining
                if (i >= 150 && i <= 170) GeneralIndustryData(i, 4, ref dblGIndustry, ref dblTemp); //Construction
                if (i >= 200 && i <= 390) GeneralIndustryData(i, 5, ref dblGIndustry, ref dblTemp); //Manufacturing
                if (i >= 400 && i <= 490) GeneralIndustryData(i, 6, ref dblGIndustry, ref dblTemp); //Transport & Public Utilities
                if (i >= 500 && i <= 510) GeneralIndustryData(i, 7, ref dblGIndustry, ref dblTemp); //Wholesale
                if (i >= 520 && i <= 590) GeneralIndustryData(i, 8, ref dblGIndustry, ref dblTemp); //Retail Trade
                if (i >= 600 && i <= 670) GeneralIndustryData(i, 9, ref dblGIndustry, ref dblTemp); //Finance, Inc. & Real Estate
                if (i >= 700 && i <= 890) GeneralIndustryData(i, 10, ref dblGIndustry, ref dblTemp); //Services
                if (i == 1000) GeneralIndustryData(i, 11, ref dblGIndustry, ref dblTemp); //Government
                //end of data extraction
            }
        }

        void PrepareSharesTable()
        {


            double[,] tmpTotal = new double[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    tmpTotal[i, j] = 0;
            }

            //Initializing shares table to zero
            tblShare = new List<PEIaPP.tblShare>();
            //list<tblShares>  MyRecordset1=new list<tblShares>();
            //MyRecordset1.deleterecordsintblshares();




            //declare matrix  MyRecordset similar to MyRecordset1
            double[] GeneralIndustryRecordset = new Double[99];
            double[] EconomicBaseRecordset = new Double[44];


            double[] MyRecordset = new Double[52]; //this is from tblshares
            //31012016
            // GeneralIndustryRecordset=repository.getgeneralindustryrecordasarray();
            GeneralIndustryRecordset = repository.getgeneralindustryrecordasarrayfromobj(tblGeneralIndustry[0]);


            EconomicBaseRecordset = repository.geteconomicbaseasarrayfromobj(tblEconomicBase[0]);

            double tr = 0;
            for (int i = 1; i < 12; i++)
            {
                if (EconomicBaseRecordset[i - 1] == 0)
                    MyRecordset[i - 1] = 0;
                else
                {
                    //Employment
                    tr = (GeneralIndustryRecordset[i - 1] / EconomicBaseRecordset[i - 1] * 100 / 1000);
                    MyRecordset[i - 1] = tr;
                    if (i == 11)
                    {
                        tmpTotal[0, 2] += GeneralIndustryRecordset[i - 1];
                        tmpTotal[0, 3] += EconomicBaseRecordset[i - 1];
                    }
                    else
                    {
                        tmpTotal[0, 0] += GeneralIndustryRecordset[i - 1];
                        tmpTotal[0, 1] += EconomicBaseRecordset[i - 1];
                    }
                }

                if (EconomicBaseRecordset[i + 10] == 0)
                    MyRecordset[i + 10] = 0;
                else
                {
                    //Income
                    MyRecordset[i + 10] = (GeneralIndustryRecordset[i + 13] / EconomicBaseRecordset[i + 10]) * 100 / 1000;
                    if (i == 11)
                    {
                        tmpTotal[1, 2] += GeneralIndustryRecordset[i + 13];
                        tmpTotal[1, 3] += EconomicBaseRecordset[i + 10];
                    }
                    else
                    {
                        tmpTotal[1, 0] += GeneralIndustryRecordset[i + 13];
                        tmpTotal[1, 1] += EconomicBaseRecordset[i + 10];
                    }
                }

                if (EconomicBaseRecordset[i + 21] == 0)
                    MyRecordset[i + 21] = 0;
                else
                {
                    //GDP
                    MyRecordset[i + 21] = (GeneralIndustryRecordset[i + 27] / EconomicBaseRecordset[i + 21]) * 100 / 1000;
                    if (i == 11)
                    {
                        tmpTotal[2, 2] += GeneralIndustryRecordset[i + 27];
                        tmpTotal[2, 3] += EconomicBaseRecordset[i + 21];
                    }
                    else
                    {
                        tmpTotal[2, 0] += GeneralIndustryRecordset[i + 27];
                        tmpTotal[2, 1] += EconomicBaseRecordset[i + 21];
                    }
                }
                if (EconomicBaseRecordset[i + 32] == 0)
                    MyRecordset[i + 32] = 0;
                else
                {
                    //Output
                    MyRecordset[i + 32] = (GeneralIndustryRecordset[i + 52] / EconomicBaseRecordset[i + 32]) * 100 / 1000;
                    if (i == 11)
                    {
                        tmpTotal[3, 2] += GeneralIndustryRecordset[i + 52];
                        tmpTotal[3, 3] += EconomicBaseRecordset[i + 32];
                    }
                    else
                    {
                        tmpTotal[3, 0] += GeneralIndustryRecordset[i + 52];
                        tmpTotal[3, 1] += EconomicBaseRecordset[i + 32];
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                MyRecordset[2 * i + 44] = (tmpTotal[i, 0] / tmpTotal[i, 1]) / 10;
                MyRecordset[2 * i + 45] = ((tmpTotal[i, 2] + tmpTotal[i, 0]) / (tmpTotal[i, 3] + tmpTotal[i, 1])) / 10;
            }
            PEIaPP.tblShare tblsharesobj = new PEIaPP.tblShare();
            tblsharesobj.Employment1 = MyRecordset[0];
            tblsharesobj.Employment2 = MyRecordset[1];
            tblsharesobj.Employment3 = MyRecordset[2];
            tblsharesobj.Employment4 = MyRecordset[3];
            tblsharesobj.Employment5 = MyRecordset[4];
            tblsharesobj.Employment6 = MyRecordset[5];
            tblsharesobj.Employment7 = MyRecordset[6];
            tblsharesobj.Employment8 = MyRecordset[7];
            tblsharesobj.Employment9 = MyRecordset[8];
            tblsharesobj.Employment10 = MyRecordset[9];
            tblsharesobj.Employment11 = MyRecordset[10];
            tblsharesobj.Income1 = MyRecordset[11];
            tblsharesobj.Income2 = MyRecordset[12];
            tblsharesobj.Income3 = MyRecordset[13];
            tblsharesobj.Income4 = MyRecordset[14];
            tblsharesobj.Income5 = MyRecordset[15];
            tblsharesobj.Income6 = MyRecordset[16];
            tblsharesobj.Income7 = MyRecordset[17];
            tblsharesobj.Income8 = MyRecordset[18];
            tblsharesobj.Income9 = MyRecordset[19];
            tblsharesobj.Income10 = MyRecordset[20];
            tblsharesobj.Income11 = MyRecordset[21];
            tblsharesobj.Gross1 = MyRecordset[22];
            tblsharesobj.Gross2 = MyRecordset[23];
            tblsharesobj.Gross3 = MyRecordset[24];
            tblsharesobj.Gross4 = MyRecordset[25];
            tblsharesobj.Gross5 = MyRecordset[26];
            tblsharesobj.Gross6 = MyRecordset[27];
            tblsharesobj.Gross7 = MyRecordset[28];
            tblsharesobj.Gross8 = MyRecordset[29];
            tblsharesobj.Gross9 = MyRecordset[30];
            tblsharesobj.Gross10 = MyRecordset[31];
            tblsharesobj.Gross11 = MyRecordset[32];
            tblsharesobj.Output1 = MyRecordset[33];
            tblsharesobj.Output2 = MyRecordset[34];
            tblsharesobj.Output3 = MyRecordset[35];
            tblsharesobj.Output4 = MyRecordset[36];
            tblsharesobj.Output5 = MyRecordset[37];
            tblsharesobj.Output6 = MyRecordset[38];
            tblsharesobj.Output7 = MyRecordset[39];
            tblsharesobj.Output8 = MyRecordset[40];
            tblsharesobj.Output9 = MyRecordset[41];
            tblsharesobj.Output10 = MyRecordset[42];
            tblsharesobj.Output11 = MyRecordset[43];
            tblsharesobj.PrivateOut = MyRecordset[44];
            tblsharesobj.TotOut = MyRecordset[45];
            tblsharesobj.PrivateEmp = MyRecordset[46];
            tblsharesobj.TotEmp = MyRecordset[49];//changed as per database to 47 to 49
            tblsharesobj.PrivateInc = MyRecordset[48];
            tblsharesobj.PrivateGDP = MyRecordset[47];//changed as per database to 49 to 47
            tblsharesobj.TotInc = MyRecordset[50];
            tblsharesobj.TotGDP = MyRecordset[51];

            //repository.addnewsharesrecord(tblsharesobj);
            tblShare.Clear(); ;
            tblShare.Add(tblsharesobj);


        }
        void PrepareDetailedTable()
        {

            //List<tblTemp> somerecordset=new List<tblTemp>();
            //somerecordset=repository.getalltbltemprecords();
            //copy all records drom tblTemp to  tblBase ..and both tables columns are same

            foreach (var x in tbltemp)
            {
                tblBase MyRecordset = new tblBase();
                MyRecordset.ID = x.ID;
                MyRecordset.Income = x.Income;
                MyRecordset.Employment = x.Employment;
                MyRecordset.GDP = x.GDP;
                MyRecordset.Output = x.Output;
                //repository.addnewtblbaserecord(MyRecordset);
                tblBase.Add(MyRecordset);


            }

        }

        void EconomicBase(ref double[,] dblTemp, ref double[,] dblGIndustry)
        {

            double[] dblIncomeTotal = new double[SECTORS];
            double[] dblEmploymentTotal = new double[SECTORS];
            double[] dblGDPTotal = new double[SECTORS];
            double[] dblSupplyTotal = new double[SECTORS];


            for (int i = 0; i < SECTORS; i++)
            {
                dblIncomeTotal[i] = 0;
                dblEmploymentTotal[i] = 0;
                dblGDPTotal[i] = 0;
                dblSupplyTotal[i] = 0;
            }

            //getBase("SELECT RIO, Supply FROM DefaultData ORDER BY RIO;", dblSupplyTotal);
            //getBase("SELECT RIO, Inc FROM DefaultData ORDER BY RIO;", dblIncomeTotal, dblSupplyTotal);
            //getBase("SELECT RIO, GDP FROM DefaultData ORDER BY RIO;", dblGDPTotal, dblSupplyTotal);
            //getBase("SELECT RIO, Emp FROM DefaultData ORDER BY RIO;", dblEmploymentTotal, dblSupplyTotal);

            dblSupplyTotal = getBase("supply");
            dblIncomeTotal = getBase("inc", dblIncomeTotal, dblSupplyTotal);
            dblGDPTotal = getBase("gdp", dblGDPTotal, dblSupplyTotal);
            dblEmploymentTotal = getBase("emp", dblEmploymentTotal, dblSupplyTotal);

            ;

            //repository.claearallrecordstbltemp();
            //Deleting all records
            tbltemp.Clear();


            for (int i = 1; i < SECTORS - 1; i++)
            {
                tblTemp MyRecordset = new tblTemp();
                MyRecordset.ID = i;
                MyRecordset.Income = dblIncomeTotal[i] / 1000;      //in thousands of dollars
                MyRecordset.Employment = dblEmploymentTotal[i] / 1000;  //in thousands of dollars
                MyRecordset.GDP = dblGDPTotal[i] / 1000;         //in thousands of dollars
                MyRecordset.Output = dblSupplyTotal[i] / 1000;   //in thousands of dollars
                //reposioty.addnewtbltemprecord(MyRecordset);
                tbltemp.Add(MyRecordset);
            }

            PrepareReport(ref dblTemp, ref dblGIndustry);

            //Initializing EconomicBase table to zero
            // repository.claearallrecordstblEconomicBase();
            tblEconomicBase.Clear();            //local

            //Deleting all records

            //Writing data into EconomicBase table

            //above i have written similar method replacing the object directly

            double[] EconomicBaseRecordset = new double[44];
            for (int o = 0; o < 44; o++)
                EconomicBaseRecordset[o] = 0;
            //repository.geteconomicbaseasarray();  //serverdata

            for (int i = 1; i < 12; i++)
            {
                EconomicBaseRecordset[i - 1] = dblGIndustry[i, 0];
                EconomicBaseRecordset[i + 10] = dblGIndustry[i, 1];
                EconomicBaseRecordset[i + 21] = dblGIndustry[i, 2];
                EconomicBaseRecordset[i + 32] = dblGIndustry[i, 3];
            }
            //pass array back as object and update
            // repository.sendingarrayformeconomicbasetbl(EconomicBaseRecordset); /// repository will convert array tp obje properties;
            //need to check this
            tblEconomicBase.Clear();
            tblEconomicBase econmicobj = new tblEconomicBase();
            if (1 < 2)
            {
                econmicobj.Employment1 = EconomicBaseRecordset[0];
                econmicobj.Employment2 = EconomicBaseRecordset[1];
                econmicobj.Employment3 = EconomicBaseRecordset[2];
                econmicobj.Employment4 = EconomicBaseRecordset[3];
                econmicobj.Employment5 = EconomicBaseRecordset[4];
                econmicobj.Employment6 = EconomicBaseRecordset[5];
                econmicobj.Employment7 = EconomicBaseRecordset[6];
                econmicobj.Employment8 = EconomicBaseRecordset[7];
                econmicobj.Employment9 = EconomicBaseRecordset[8];
                econmicobj.Employment10 = EconomicBaseRecordset[9];
                econmicobj.Employment11 = EconomicBaseRecordset[10];
                econmicobj.Income1 = EconomicBaseRecordset[11];
                econmicobj.Income2 = EconomicBaseRecordset[12];
                econmicobj.Income3 = EconomicBaseRecordset[13];
                econmicobj.Income4 = EconomicBaseRecordset[14];
                econmicobj.Income5 = EconomicBaseRecordset[15];
                econmicobj.Income6 = EconomicBaseRecordset[16];
                econmicobj.Income7 = EconomicBaseRecordset[17];
                econmicobj.Income8 = EconomicBaseRecordset[18];
                econmicobj.Income9 = EconomicBaseRecordset[19];
                econmicobj.Income10 = EconomicBaseRecordset[20];
                econmicobj.Income11 = EconomicBaseRecordset[21];
                econmicobj.Gross1 = EconomicBaseRecordset[22];
                econmicobj.Gross2 = EconomicBaseRecordset[23];
                econmicobj.Gross3 = EconomicBaseRecordset[24];
                econmicobj.Gross4 = EconomicBaseRecordset[25];
                econmicobj.Gross5 = EconomicBaseRecordset[26];
                econmicobj.Gross6 = EconomicBaseRecordset[27];
                econmicobj.Gross7 = EconomicBaseRecordset[28];
                econmicobj.Gross8 = EconomicBaseRecordset[29];
                econmicobj.Gross9 = EconomicBaseRecordset[30];
                econmicobj.Gross10 = EconomicBaseRecordset[31];
                econmicobj.Gross11 = EconomicBaseRecordset[32];
                econmicobj.Output1 = EconomicBaseRecordset[33];
                econmicobj.Output2 = EconomicBaseRecordset[34];
                econmicobj.Output3 = EconomicBaseRecordset[35];
                econmicobj.Output4 = EconomicBaseRecordset[36];
                econmicobj.Output5 = EconomicBaseRecordset[37];
                econmicobj.Output6 = EconomicBaseRecordset[38];
                econmicobj.Output7 = EconomicBaseRecordset[39];
                econmicobj.Output8 = EconomicBaseRecordset[40];
                econmicobj.Output9 = EconomicBaseRecordset[41];
                econmicobj.Output10 = EconomicBaseRecordset[42];
                econmicobj.Output11 = EconomicBaseRecordset[43];


            }
            tblEconomicBase.Add(econmicobj);

            PrepareSharesTable();
        }

        void PrepareIndustriesReports()
        {
            double[,] dblTemp = new double[SICSECTORS, 4];
            double[,] dblGIndustry = new double[12, 4];
            for (int i = 0; i < SICSECTORS; i++)
                for (int j = 0; j < 4; j++)
                    dblTemp[i, j] = 0;
            for (int i = 0; i < 12; i++)
                for (int j = 0; j < 4; j++)
                    dblGIndustry[i, j] = 0;

            //Preparing Division level report
            PrepareReport(ref dblTemp, ref dblGIndustry);
            tblIndustry MyRecordset = new tblIndustry();
            tblIndustry = new List<tblIndustry>();

            for (int i = 0; i < SICSECTORS; i++)
            {
                //MyRecordset->Open(dbOpenDynaset, "SELECT * FROM tblIndustry WHERE SIC = " + Utils::IntToString(i) + ";", dbConsistent);



                if (repository.gettbinduustryobjectbySIC(i) != null)
                {
                    MyRecordset = repository.gettbinduustryobjectbySIC(i);

                    MyRecordset.Employment = dblTemp[i, 0]; //Employment
                    MyRecordset.Income = dblTemp[i, 1]; //Income
                    MyRecordset.GrossStateProduct = dblTemp[i, 2]; //GDP GrossstateProduct
                    MyRecordset.Output = dblTemp[i, 3]; //Output
                    //repository.updaterecordbySIC(MyRecordset);
                    tblIndustry.Add(MyRecordset);
                }

            }


            //Initializing GeneralIndustry table to zero

            //MyRecordset->Open(dbOpenDynaset, "SELECT * FROM tblGeneralIndustry;", dbConsistent);
            //for(i = 0; i < 74; i++)
            //    MyRecordset[i]= 0;

            ///repository.setallcolumnstozerotblGeneralIndustry();//should have 74 columns
            ///
            tblGeneralIndustry.Clear();
            //Finished initializing

            //Writing data into GeneralIndustry table
            double[] GeneralIndustryRecordset = new Double[99];


            //repository.updategeneralindustryrecordsetbyarray(GeneralIndustryRecordset);
            //m123
            tblGeneralIndustry gi = new tblGeneralIndustry();
            //trying way to fill with zero
            for (int l = 0; l < 99; l++)
                GeneralIndustryRecordset[l] = 0;
            // GeneralIndustryRecordset=  repository.getgeneralindustryrecordasarrayfromobj(tblGeneralIndustry[0]);
            // GeneralIndustryRecordset=repository.getgeneralindustryrecordasarray();
            //s     
            for (int i = 1; i < 12; i++)
            {
                GeneralIndustryRecordset[i - 1] = dblGIndustry[i, 0]; //Employment
                GeneralIndustryRecordset[i + 13] = dblGIndustry[i, 1]; //Income
                GeneralIndustryRecordset[i + 27] = dblGIndustry[i, 2]; //GDP
                GeneralIndustryRecordset[i + 52] = dblGIndustry[i, 3]; //Output
            }
            if (1 < 2)
            {
                gi.Employment1 = GeneralIndustryRecordset[0];
                gi.Employment2 = GeneralIndustryRecordset[1];
                gi.Employment3 = GeneralIndustryRecordset[2];
                gi.Employment4 = GeneralIndustryRecordset[3];
                gi.Employment5 = GeneralIndustryRecordset[4];
                gi.Employment6 = GeneralIndustryRecordset[5];
                gi.Employment7 = GeneralIndustryRecordset[6];
                gi.Employment8 = GeneralIndustryRecordset[7];
                gi.Employment9 = GeneralIndustryRecordset[8];
                gi.Employment10 = GeneralIndustryRecordset[9];
                gi.Employment11 = GeneralIndustryRecordset[10];
                gi.Employment12 = GeneralIndustryRecordset[11];
                gi.Employment13 = GeneralIndustryRecordset[12];
                gi.Employment14 = GeneralIndustryRecordset[13];
                gi.Income1 = GeneralIndustryRecordset[14];
                gi.Income2 = GeneralIndustryRecordset[15];
                gi.Income3 = GeneralIndustryRecordset[16];
                gi.Income4 = GeneralIndustryRecordset[17];
                gi.Income5 = GeneralIndustryRecordset[18];
                gi.Income6 = GeneralIndustryRecordset[19];
                gi.Income7 = GeneralIndustryRecordset[20];
                gi.Income8 = GeneralIndustryRecordset[21];
                gi.Income9 = GeneralIndustryRecordset[22];
                gi.Income10 = GeneralIndustryRecordset[23];
                gi.Income11 = GeneralIndustryRecordset[24];
                gi.Income12 = GeneralIndustryRecordset[25];
                gi.Income13 = GeneralIndustryRecordset[26];
                gi.Income14 = GeneralIndustryRecordset[27];
                gi.Gross1 = GeneralIndustryRecordset[28];
                gi.Gross2 = GeneralIndustryRecordset[29];
                gi.Gross3 = GeneralIndustryRecordset[30];
                gi.Gross4 = GeneralIndustryRecordset[31];
                gi.Gross5 = GeneralIndustryRecordset[32];
                gi.Gross6 = GeneralIndustryRecordset[33];
                gi.Gross7 = GeneralIndustryRecordset[34];
                gi.Gross8 = GeneralIndustryRecordset[35];
                gi.Gross9 = GeneralIndustryRecordset[36];
                gi.Gross10 = GeneralIndustryRecordset[37];
                gi.Gross11 = GeneralIndustryRecordset[38];
                gi.Gross12 = GeneralIndustryRecordset[39];
                gi.Gross13 = GeneralIndustryRecordset[40];
                gi.Gross14 = GeneralIndustryRecordset[41];
                gi.Gross15 = GeneralIndustryRecordset[42];
                gi.Gross16 = GeneralIndustryRecordset[43];
                gi.Gross17 = GeneralIndustryRecordset[44];
                gi.Gross18 = GeneralIndustryRecordset[45];
                gi.Gross19 = GeneralIndustryRecordset[46];
                gi.Gross20 = GeneralIndustryRecordset[47];
                gi.Gross21 = GeneralIndustryRecordset[48];
                gi.Gross22 = GeneralIndustryRecordset[49];
                gi.Gross23 = GeneralIndustryRecordset[50];
                gi.Gross24 = GeneralIndustryRecordset[51];
                gi.Gross25 = GeneralIndustryRecordset[52];
                gi.Output1 = GeneralIndustryRecordset[53];
                gi.Output2 = GeneralIndustryRecordset[54];
                gi.Output3 = GeneralIndustryRecordset[55];
                gi.Output4 = GeneralIndustryRecordset[56];
                gi.Output5 = GeneralIndustryRecordset[57];
                gi.Output6 = GeneralIndustryRecordset[58];
                gi.Output7 = GeneralIndustryRecordset[59];
                gi.Output8 = GeneralIndustryRecordset[60];
                gi.Output9 = GeneralIndustryRecordset[61];
                gi.Output10 = GeneralIndustryRecordset[62];
                gi.Output11 = GeneralIndustryRecordset[63];
                gi.Output12 = GeneralIndustryRecordset[64];
                gi.Output13 = GeneralIndustryRecordset[65];
                gi.Output14 = GeneralIndustryRecordset[66];
                gi.InitialEffect = GeneralIndustryRecordset[67];
                gi.Gross26 = GeneralIndustryRecordset[68];
                gi.Gross27 = GeneralIndustryRecordset[69];
                gi.Gross28 = GeneralIndustryRecordset[70];
                gi.Gross29 = GeneralIndustryRecordset[71];
                gi.Gross30 = GeneralIndustryRecordset[72];
                gi.PersonalIncome = GeneralIndustryRecordset[73];



            }

            //tblGeneralIndustry MyRecordset=repository.getfirstrecordfromgeneralindustry();
            ////Temp
            tblGeneralIndustry MyRecordset_n = gi;
            MyRecordset_n.Employment12 = dblDirectEmp / 1000;
            MyRecordset_n.Income12 = dblDirectInc / 1000;
            MyRecordset_n.Gross12 = dblDirectGDP / 1000;
            MyRecordset_n.Output12 = dblOutDirEff / 1000;

            MyRecordset_n.Employment13 = (dblTotalEmp - dblDirectEmp) / 1000;
            MyRecordset_n.Income13 = (dblTotalInc - dblDirectInc) / 1000;
            MyRecordset_n.Gross13 = (dblTotalGDP - dblDirectGDP) / 1000;
            MyRecordset_n.Output13 = (dblOutTotEff - dblOutDirEff) / 1000;

            if (dblDirectEmp != 0)
                MyRecordset_n.Employment14 = dblTotalEmp / dblDirectEmp;
            if (dblDirectInc != 0)
                MyRecordset_n.Income14 = dblTotalInc / dblDirectInc;
            if (dblDirectGDP != 0)
                MyRecordset_n.Gross14 = dblTotalGDP / dblDirectGDP;
            if (dblOutDirEff != 0)
                MyRecordset_n.Output14 = dblOutTotEff / dblOutDirEff;

            MyRecordset_n.Gross26 = dblWages / 1000;
            MyRecordset_n.Gross27 = dblLocal / 1000;
            MyRecordset_n.Gross16 = dblTotalLocal / 1000;
            MyRecordset_n.Gross28 = dblState / 1000;
            MyRecordset_n.Gross17 = dblTotalState / 1000;
            MyRecordset_n.Gross29 = dblFederal / 1000;
            MyRecordset_n.Gross18 = dblTotalFederal / 1000;
            MyRecordset_n.Gross30 = 0;  //Household Social Security
            MyRecordset_n.Gross19 = dblFederalIns / 1000;
            MyRecordset_n.Gross20 = ((dblTotalGDP - dblWages - dblLocal - dblState - dblFederal - dblFederalIns) / 1000);
            MyRecordset_n.PersonalIncome = dblPersonalInc;

            if (dblInitialEffect != 0)
            {
                MyRecordset_n.Gross21 = (dblTotalEmp / 1000) / (dblInitialEffect / 1000000);
                MyRecordset_n.Gross22 = (dblTotalInc) / (dblInitialEffect / 1000000);
                MyRecordset_n.Gross23 = (dblTotalState) / (dblInitialEffect / 1000000);
                MyRecordset_n.Gross24 = (dblTotalLocal) / (dblInitialEffect / 1000000);
                MyRecordset_n.Gross25 = (dblTotalGDP) / (dblInitialEffect / 1000000);
                MyRecordset_n.InitialEffect = dblInitialEffect;
            }

            //repository.updategeneralindustry(repository);
            tblGeneralIndustry.Clear();//since it holds one row  i have removed and added new
            tblGeneralIndustry.Add(MyRecordset_n);

            PrepareDetailedTable();   //update tbl base with tbltemp
            //Calculating Economic Base and preparing tblEconomicBase
            EconomicBase(ref dblTemp, ref dblGIndustry);
        }

        void PrepareReportTables()
        {
            PrepareIndustriesReports();
        }

        void PrepareOccupationalReport()
        {
            double[] OccupationResults = new double[651];
            double[] tblTemplocal = new double[651];
            int index;
            int index2;

            for (int i = 0; i < 651; i++)
            {
                OccupationResults[i] = 0;
                if (i < SECTORS - 2) tblTemplocal[i] = 0;
            }

            List<tblTemp> tblTemprecods = tbltemp; //repository.getalltblTemprecordsorderbyid();
            foreach (var MyRecordset in tblTemprecods)
            {
                if (MyRecordset.ID < SECTORS - 2)
                {
                    tblTemplocal[MyRecordset.ID] = MyRecordset.Employment ?? default(double);
                }
            }

            List<OccupationDistribution> OccupationDistributionrecords = repository.getallOccupationDistributionrecordsorderbyid();
            foreach (var MyRecordset in OccupationDistributionrecords)
            {


                index = (int)MyRecordset.OccupationIndex;
                index2 = (int)MyRecordset.RIO;
                OccupationResults[index] += tblTemplocal[index2] * (MyRecordset.Percent ?? default(double));


            }
            List<tblOccupation> staticdata = repository.getallOccupationecordsorderbyid();

            foreach (var MyRecordset in staticdata.ToList())
            {
                //updating each record in list of tbloccupations with   ocuupational we created just before

                index = (int)MyRecordset.OccupationIndex;
                MyRecordset.Value = OccupationResults[index];

                //repository.updatetblOccupations(MyRecordset);
                tblOccupationsrecords.Add(MyRecordset);

            }



        }

        void getActivities()
        {
            for (int i = 0; i < SECTORS; i++) dblCalcVector[i] = 0;
            string y = "";
            switch ((int)_nVectorSettings[TEMP])
            {
                case 0:
                    MainStreetCalc();
                    break;
                case 1:
                    MuseumsCalc();
                    break;
                case 2:
                    TourismCalc();
                    break;
                case 3:
                    RehabCalc();
                    break;
                case 4:
                    MainStreetCalc();
                    TourismCalc();
                    RehabCalc();
                    MuseumsCalc();
                    break;
                default:
                    break;
            }
        }

        void CalculateMultiRegionRPCArray(double[,] MultiRegionRPCArray, int[,] MultiRegionArray)
        {
            int i, j;
            double columnSum;
            double[] Population = new double[NumberOfMultipleRegions];
            int gDistanceExponent = 1;     // Distance exponent
            int gGravityCoeficient = 1;    // Gravity coeficient
            //String strSQL;     //SQL Statement
            Population = repository.getpopulationcolumnasarrayfromAreatablesofallregions(region_name);

            for (i = 0; i < NumberOfMultipleRegions; i++)
            {
                columnSum = 0;
                for (j = 0; j < NumberOfMultipleRegions; j++)
                {
                    if (Math.Pow(MultiRegionArray[i, j], gDistanceExponent) != 0)
                    {
                        MultiRegionRPCArray[i, j] = Math.Pow((gGravityCoeficient * Population[i] / MultiRegionArray[i, j]), gDistanceExponent);
                    }
                    else
                    {
                        MultiRegionRPCArray[i, j] = 0;
                    }
                }
            }

            for (j = 0; j < NumberOfMultipleRegions; j++)
            { //column movement
                columnSum = 0;
                for (i = 0; i < NumberOfMultipleRegions; i++)
                {  //row movement
                    columnSum += MultiRegionRPCArray[i, j];
                }
                if (columnSum != 0)
                {
                    for (i = 0; i < NumberOfMultipleRegions; i++)
                    {  //normalizing to 0.95
                        MultiRegionRPCArray[i, j] = MultiRegionRPCArray[i, j] / columnSum * 0.95;
                    }
                }
            }
        }
        void MTVM(double[,] aMatrix, double[] PassedVector)
        {  //MatrixToVectorMultiplication
            long i;
            long j;
            double sum;

            for (i = 0; i < NumberOfMultipleRegions * (SECTORS - 2); i++)
            {
                sum = 0;
                for (j = 0; j < NumberOfMultipleRegions * (SECTORS - 2); j++)
                {
                    sum += aMatrix[i, j] * PassedVector[j];  //staying on the same row thus column changes
                }
                ResultVector[i] = sum;
            }
        }
        public void MultiregionCalculationsThread()
        {
            double[] dblCalcVectorMultiregion = new double[SECTORS];
            double[,] RegionalRPC = new double[NumberOfMultipleRegions, SECTORS - 2]; //RPC's of all the regions in a multiregion
            double[,] ByRegionDemand = new double[NumberOfMultipleRegions, SECTORS - 2]; //holds demands of all regions
            double[,] UnmetDemand = new double[NumberOfMultipleRegions, SECTORS - 2]; //applies by column
            double[,] Exports = new double[NumberOfMultipleRegions, SECTORS - 2]; //applies by row
            double[,] ProbMatrix = new double[NumberOfMultipleRegions, NumberOfMultipleRegions];   //probability matrix
            double[, ,] ResultMatrix = new double[NumberOfMultipleRegions, NumberOfMultipleRegions, SECTORS - 2];
            double[,] ResultMatrixRowSum = new double[NumberOfMultipleRegions, SECTORS - 2];  //matrix that holds the sum of each row for each industry of the result matrix
            double[] MultiplierVector = new double[NumberOfMultipleRegions * (SECTORS - 2)];//holds partial initial impacts for the MultiRegion
            double[] InitialImpactsVector = new double[NumberOfMultipleRegions * (SECTORS - 2)];//holds full initial impacts for the MultiRegion
            double[] ResultVector1 = new double[NumberOfMultipleRegions * (SECTORS - 2)];
            double[] ResultVector2 = new double[NumberOfMultipleRegions * (SECTORS - 2)];
            double[] ResultVector3 = new double[NumberOfMultipleRegions * (SECTORS - 2)];
            double[] ResultVector4 = new double[NumberOfMultipleRegions * (SECTORS - 2)];
            double[] ResultVector5 = new double[NumberOfMultipleRegions * (SECTORS - 2)];
            double[] ResultVector6 = new double[NumberOfMultipleRegions * (SECTORS - 2)];
            double[] ResultVector7 = new double[NumberOfMultipleRegions * (SECTORS - 2)]; //all seven vectors are used in the calculation of an approximation of inverse of the huge matrix
            double[] ConstructionEmployment = new double[NumberOfMultipleRegions * (SECTORS - 2)]; //this vector is going to hold the construction employment for all regions in a multiregion

            int[,] MultiRegionArray = new int[NumberOfMultipleRegions, NumberOfMultipleRegions];

            double rValue;
            int RegionNumber;
            int i, j, k, l, r, c;
            int industry;
            double DiagonalValue;
            String PathName;
            String strSQL;     //SQL Statement
            double sum;

            int flagMetaRegionReports = 0;    //boolean var

            // initialization of global variables
            dblDirectEmp = 0;
            dblDirectInc = 0;
            dblDirectGDP = 0;
            dblWages = 0;
            dblLocal = 0;
            dblState = 0;
            dblFederal = 0;
            dblFederalIns = 0;
            dblProfits = 0;
            dblTotalEmp = 0;
            dblTotalInc = 0;
            dblTotalGDP = 0;
            dblInitialEffect = 0;
            // end of initialization

            region_name = region_name;

            // initialization of arrays
            for (i = 0; i < NumberOfMultipleRegions; i++)
            {
                ConstructionEmployment[i] = 0;
                for (j = 0; j < NumberOfMultipleRegions; j++)
                {
                    MultiRegionRPCArray[i, j] = 0;
                }
            }

            for (i = 0; i < NumberOfMultipleRegions; i++)
            {
                int tRIO;
                double tDemand;
                double tP;
                double tSupply;
                List<generic_DefaultData> riop = null;
                if (i == 0)
                    riop = repository.getdefaultrecords(region_name + "Rest");
                if (i == 1)
                    riop = repository.getdefaultrecords(region_name);
                foreach (var x in riop)
                {
                    tRIO = (x.RIO - 1) ?? default(int);   // since we start indexing from 0
                    tDemand = x.Demand ?? default(double);
                    tP = x.P ?? default(double);
                    tSupply = x.Supply ?? default(double);
                    UnmetDemand[i, tRIO] = tDemand - (tP * tDemand);
                    RegionalRPC[i, tRIO] = tP;
                    ByRegionDemand[i, tRIO] = tDemand;
                    if ((tP * tDemand) > tSupply)
                    {
                        Exports[i, tRIO] = 0;
                    }
                    else
                    {
                        Exports[i, tRIO] = tSupply - tP * tDemand;
                    }
                    /*
                            If RegRecordset!rio = 54 Or RegRecordset!rio = 55 Then '//calculate construction employment
                                ConstructionEmployment(RegionNumber) = ConstructionEmployment(RegionNumber) + RegRecordset!emp * RegRecordset!Supply
                            End If
                    */

                }
            }


            //OBTAINING AMATRIX FROM THE DATABASE

            for (RegionNumber = 0; RegionNumber < NumberOfMultipleRegions; RegionNumber++)
            {

                //strSQL = "SELECT * FROM AMatrix ORDER BY ID;";


                List<generic_AMatrix> RegRecordset;
                if (i == 0)
                    RegRecordset = repository.getregioanlamtrix(region_name + "Rest");
                else
                    RegRecordset = repository.getregioanlamtrix(region_name);
                int rsSize;
                int recposition = 0;

                for (i = 0; i < (SECTORS - 2); i++)
                {
                    for (j = 0; j < (SECTORS - 2); j++)
                    {
                        dblMatrix[i, j, RegionNumber] = RegRecordset[recposition].VALUE ?? default(double);
                        recposition++;
                    }
                }

            }
            //Finished getting AMatrix



            //CALCULATING PROBABILITY MATRIX
            ProbMatrix[0, 0] = 0;
            ProbMatrix[0, 1] = 1;
            ProbMatrix[1, 0] = 1;
            ProbMatrix[1, 1] = 0;

            //END OF CALCULATING PROBABILITY MATRIX

            //Travel Time Distance Matrix as provided by Mike
            MultiRegionArray[0, 0] = 10;
            MultiRegionArray[0, 1] = 100;
            MultiRegionArray[1, 0] = 100;
            MultiRegionArray[1, 1] = 100;

            CalculateMultiRegionRPCArray(MultiRegionRPCArray, MultiRegionArray);

            /*
                //Show user last RPC's estimations for construction so that the user could change them
                For j = 1 To NumberOfMultipleRegions '//column movement
                    columnSum = 0
                    For i = 1 To NumberOfMultipleRegions '//row movement
                        If Val(MultiRegionArray(i, j)) = 0 Then
                            ConstructionArray(i, j) = 0
                        Else
                            ConstructionArray(i, j) = Format$(ConstructionEmployment(i) / Val(MultiRegionArray(i, j)), "##,##0.00000")
                        End If
                        columnSum = columnSum + ConstructionArray(i, j)
                    Next i
                    If columnSum <> 0 Then
                        For i = 1 To NumberOfMultipleRegions '//normalizing to 0.95
                            ConstructionArray(i, j) = Format$(ConstructionArray(i, j) / columnSum * 0.95, "##,##0.00000")
                        Next i
                    End If
                Next j
            */


            //APPLYING UNMET-DEMAND TO THE PROBABILITY MATRIX
            for (industry = 0; industry < SECTORS - 2; industry++)
            {              //industry movement
                for (j = 0; j < NumberOfMultipleRegions; j++)
                {          //column movement
                    for (i = 0; i < NumberOfMultipleRegions; i++)
                    {      //row movement
                        ResultMatrix[i, j, industry] = ProbMatrix[i, j] * UnmetDemand[j, industry];
                        if (j == 0)
                        {
                            ResultMatrixRowSum[i, industry] = ResultMatrix[i, j, industry];
                        }
                        else
                            ResultMatrixRowSum[i, industry] = ResultMatrixRowSum[i, industry] + ResultMatrix[i, j, industry];
                    }
                }
            }
            //FINISHED

            //ADJUSTING THE RESULTED MATRIX DEPENDING ON EXPORTS (Provisional Trade matrix is the result)
            for (industry = 0; industry < SECTORS - 2; industry++)
            { //industry movement
                for (i = 0; i < NumberOfMultipleRegions; i++)
                { //row movement
                    if (Exports[i, industry] == 0)
                    {
                        for (j = 0; j < NumberOfMultipleRegions; j++)
                        { //column movement
                            ResultMatrix[i, j, industry] = 0;
                        }
                    }
                    else
                    {
                        if (ResultMatrixRowSum[i, industry] > Exports[i, industry])
                        {
                            for (j = 0; j < NumberOfMultipleRegions; j++)
                            {  //column movement
                                ResultMatrix[i, j, industry] = (Exports[i, industry] / ResultMatrixRowSum[i, industry]) * ResultMatrix[i, j, industry];
                            }
                        }
                        //else {
                        //    for (j = 0; j < NumberOfMultipleRegions; j++) { //column movement
                        //        ResultMatrix[i,j][industry] = ResultMatrix[i][j][industry];
                        //    }
                        //}
                    }
                }
            }


            //FINISHED

            //INITIALIZING THE HUGE MATRIX WHICH WILL HAVE TO BE INVERTED
            for (r = 0; r < NumberOfMultipleRegions * (SECTORS - 2); r++)
            {
                for (c = 0; c < NumberOfMultipleRegions * (SECTORS - 2); c++)
                {
                    HugeMatrix[r, c] = 0;
                }
            }

            //THE HUGE MATRIX IS THE RPC MATRIX
            for (i = 0; i < NumberOfMultipleRegions; i++)
            {    //i-from region (row)
                for (j = 0; j < NumberOfMultipleRegions; j++)
                {     //j-to region (column)
                    if (i != j)
                    {
                        for (industry = 0; industry < (SECTORS - 2); industry++)
                        {
                            if (ByRegionDemand[j, industry] != 0)
                                HugeMatrix[i * (SECTORS - 2) + industry, j * (SECTORS - 2) + industry] = ResultMatrix[i, j, industry] / ByRegionDemand[j, industry];
                            if (industry == (SECTORS - 2)) //loading construction RPC's
                                HugeMatrix[i * (SECTORS - 2) + industry, j * (SECTORS - 2) + industry] = MultiRegionRPCArray[i, j];
                        }
                    }
                    else
                    {             //PUTTING RPC'S FOR DIAGONAL OF THE HUGE MATRIX
                        for (industry = 0; industry < (SECTORS - 2); industry++)
                        {
                            HugeMatrix[i * (SECTORS - 2) + industry, j * (SECTORS - 2) + industry] = RegionalRPC[j, industry];
                            if (industry == (SECTORS - 2))           //loading construction RPC's
                                HugeMatrix[i * (SECTORS - 2) + industry, j * (SECTORS - 2) + industry] = MultiRegionRPCArray[i, j];
                        }
                    }
                }
            }
            //FINISHED

            //CALCULATING INITIAL EFFECTS

            for (j = 0; j < NumberOfMultipleRegions * (SECTORS - 2); j++)
                InitialImpactsVector[j] = 0;

            //calculation initial impacts

            //Initializing vector to zero
            for (i = 0; i < NumberOfMultipleRegions * (SECTORS - 2); i++)
            {
                MultiplierVector[i] = 0;  //value
            }
            for (i = 0; i < SECTORS; i++)
            {
                dblCalcVectorMultiregion[i] = 0;  //value
            }
            //End of initializing
            //need to rework              
            // getActivities(dblCalcVectorMultiregion);
            getActivities();

            //these 2 methods i need to pass  dblCalcVectorMultiregion  but instead of tht passed dblCalcVector and assigning the result back dblCalcVector dblCalcVectorMultiregion


            //TranslatePCIO(dblCalcVectorMultiregion);
            TranslatePCIO();

            for (int oi = 0; oi < SECTORS; oi++)
                dblCalcVectorMultiregion[oi] = dblCalcVector[oi] ?? default(double);//a new lines code added
            for (int oi = 0; oi < SECTORS; oi++)
                dblCalcVector[oi] = 0;//a new lines code added

            for (r = 0; r < NumberOfMultipleRegions; r++)
            {
                for (j = 0; j < (SECTORS - 2); j++)
                {
                    if (r == 0)
                        MultiplierVector[r * SECTORS - 2 + j] = 0;
                    else
                        MultiplierVector[r * SECTORS - 2 + j] = dblCalcVectorMultiregion[j + 1];
                }
            }

            //Now multiply initial impacts by the rpc matrix to get initial impacts

            for (l = 0; l < NumberOfMultipleRegions * (SECTORS - 2); l++)
            {
                sum = 0;
                for (k = 0; k < NumberOfMultipleRegions * (SECTORS - 2); k++)
                {
                    sum = sum + HugeMatrix[l, k] * MultiplierVector[k];    //staying on the same row thus column changes
                }
                InitialImpactsVector[l] = InitialImpactsVector[l] + sum;
            }
            // End of calculating initial impacts



            //MULTIPLYING HUGE MATRIX BY AMATRIX (Since it is a mostly diagonal matrix diagonal cell by row multiplication is used)
            for (i = 0; i < NumberOfMultipleRegions; i++)
            { //i-from region
                for (j = 0; j < NumberOfMultipleRegions; j++)
                { //j-to region
                    for (k = 0; k < (SECTORS - 2); k++)
                    {
                        DiagonalValue = HugeMatrix[i * (SECTORS - 2) + k, j * (SECTORS - 2) + k];
                        for (l = 0; l < (SECTORS - 2); l++)
                        { //(Leave out last column, must stay as is for multiregion)
                            HugeMatrix[i * (SECTORS - 2) + k, j * (SECTORS - 2) + l] = DiagonalValue * dblMatrix[k, l, j];
                            //i-region, k-row, l-column, note: in dblMatrix j specifies the region who's AMatrix is being used
                        }
                    }
                }
            }
            //FINISHED


            //INVERTING THE HUGE MATRIX USING THE APPROXIMATION METHOD
            for (i = 0; i < NumberOfMultipleRegions * (SECTORS - 2); i++)
            {  //initializing
                ResultVector[i] = 0;
            }

            MTVM(HugeMatrix, InitialImpactsVector);

            for (i = 0; i < NumberOfMultipleRegions * (SECTORS - 2); i++)
            {
                ResultVector1[i] = ResultVector[i];
            }


            MTVM(HugeMatrix, ResultVector1);
            for (i = 0; i < NumberOfMultipleRegions * (SECTORS - 2); i++)
            {
                ResultVector2[i] = ResultVector[i];
            }

            MTVM(HugeMatrix, ResultVector2);
            for (i = 0; i < NumberOfMultipleRegions * (SECTORS - 2); i++)
            {
                ResultVector3[i] = ResultVector[i];
            }
            MTVM(HugeMatrix, ResultVector3);
            for (i = 0; i < NumberOfMultipleRegions * (SECTORS - 2); i++)
            {
                ResultVector4[i] = ResultVector[i];
            }
            MTVM(HugeMatrix, ResultVector4);
            for (i = 0; i < NumberOfMultipleRegions * (SECTORS - 2); i++)
            {
                ResultVector5[i] = ResultVector[i];
            }
            MTVM(HugeMatrix, ResultVector5);
            for (i = 0; i < NumberOfMultipleRegions * (SECTORS - 2); i++)
            {
                ResultVector6[i] = ResultVector[i];
            }


            rValue = 0;

            sum = 0;
            for (i = 0; i < NumberOfMultipleRegions * (SECTORS - 2); i++)
            {
                if (ResultVector5[i] != 0)
                {
                    sum += ResultVector6[i] / ResultVector5[i];
                }
            }

            rValue = sum / (NumberOfMultipleRegions * (SECTORS - 2));

            for (i = 0; i < NumberOfMultipleRegions * (SECTORS - 2); i++)
            {
                ResultVector7[i] = (rValue / (1 - rValue)) * ResultVector6[i];
            }

            //RESULT VECTOR
            for (i = 0; i < NumberOfMultipleRegions * (SECTORS - 2); i++)
            {
                ResultVector[i] = InitialImpactsVector[i] + ResultVector1[i] + ResultVector2[i] + ResultVector3[i] + ResultVector4[i] + ResultVector5[i] + ResultVector6[i] + ResultVector7[i];
            }

            //TEST
            sum = 0;
            for (l = 0; l < NumberOfMultipleRegions * (SECTORS - 2); l++)
            {
                sum += ResultVector[l];
            }

            //ReportRegion = "Metaregion";

            //lblInformation.caption = "Please wait while reports for " & ReportRegion & " are being created."

            for (i = 0; i < SECTORS; i++)
            {
                dblCalcVector[i] = 0;
            }

            for (i = 0; i < NumberOfMultipleRegions; i++)
            {
                sum = 0;
                for (industry = 1; industry < (SECTORS - 2); industry++)
                {
                    dblCalcVector[industry] += InitialImpactsVector[(SECTORS - 2) * i + industry - 1];
                }
            }

            // calculating direct effects
            for (i = 1, dblOutDirEff = 0; i < SECTORS - 2; i++)
            {
                dblOutDirEff += dblCalcVector[i];
            }


            //need to rework
            CalculateDirectEffect();

            for (i = 0; i < SECTORS; i++)
            {
                dblCalcVector[i] = 0;
            }
            for (i = 0; i < NumberOfMultipleRegions; i++)
            {
                sum = 0;
                for (industry = 1; industry < (SECTORS - 1); industry++)
                {
                    dblCalcVector[industry] += ResultVector[(SECTORS - 2) * i + industry - 1];
                }
            }

            //pStatus->SetWindowText("Preparing Tables");

            for (i = 1, dblOutTotEff = 0; i < SECTORS - 2; i++)
            {
                if (dblCalcVector[i] != 0)
                    dblOutTotEff += dblCalcVector[i];
            }

            // Writing into the database
            //need to rework
            PrepareTempTables();
            //pProgress->SetPos(75);

            //pStatus->SetWindowText("Making Reports");

            // Preparing Report Tables

            PrepareOccupationalReport();

            //pProgress->SetPos(80);

            PrepareReportTables();
            //pProgress->SetPos(100);






        }


    }
}