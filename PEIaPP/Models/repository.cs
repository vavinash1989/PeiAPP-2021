using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PEIaPP.Models
{
    public static class repository
    {
        public static List<historymodelview> getuserhistory(string wuser)
        {
            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = from emp in Ganesh.Histories
                           where emp.emailid == wuser
                           select new historymodelview()
                           {

                               logid = emp.RecordiD.ToString(),
                               datetime =(emp.datetime),
                               country=emp.country,
                               region=emp.region.ToString()
                           };
            if (empQuery != null)
            {
                //    List<historymodelview> empList = empQuery.ToList();
                //    return empList;
                return new List<historymodelview>();
            }
            else
                return new List<historymodelview>();
            
        }


        public static History getselectedrecord(int id)
        {
            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = from emp in Ganesh.Histories
                           where emp.RecordiD == id
                           select  new History();
                          
            if (empQuery != null)
            {
                //    List<historymodelview> empList = empQuery.ToList();
                //    return empList;
                return new History();
            }
            else
                return new History();

        }

        //foreach (var prop in bo.GetType().GetProperties())
        //    {
        //        Console.WriteLine("{0} = {1}", prop.Name, prop.GetValue(bo, null));
        //    }
        //        z_AlabamaRest_AMatrix
        //Alabama_DefaultData
        //Alabama_LeontievInverse
        //AlabamaRest_DefaultData
        //Alabama_Area
        //AlabamaRest_Area
        //Alabama_AMatrix
        public static List<pckeyvalue> getlistofnewstoresandrestaurants()
        {

            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = from emp in Ganesh.New_Stores_and_Restaurants
                           select new pckeyvalue()
                           {
                               PC_KEY = emp.PC_KEY,
                               VALUE = emp.VALUE
                           };
            List<pckeyvalue> empList = empQuery.ToList();
            return empList;
        }

        public static List<pckeyvalue> getlistoffte()
        {
            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = from emp in Ganesh.FTEs
                           select new pckeyvalue()
                           {
                               PC_KEY = emp.PC_KEY,
                               VALUE = emp.VALUE
                           };
            List<pckeyvalue> empList = empQuery.ToList();
            return empList;
        }

        public static List<pckeyvalue> getlistofrehaboncondition(int whre)
        {
            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = from emp in Ganesh.Rehabs
                           where emp.RH_KEY == whre
                           select new pckeyvalue()
                           {
                               PC_KEY = emp.PC_KEY,
                               VALUE = emp.VALUE
                           };
            List<pckeyvalue> empList = empQuery.ToList();
            return empList;
        }


        public static List<pckeyvalue> getlistofrehabdaytrip()
        {

            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = from emp in Ganesh.Rehabs
                           select new pckeyvalue()
                           {
                               PC_KEY = emp.PC_KEY,
                               VALUE = emp.VALUE
                           };
            List<pckeyvalue> empList = empQuery.ToList();
            return empList;

        }
        public static List<pckeyvalue> getlistofdaytrip()
        {

            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = from emp in Ganesh.Day_Trips
                           select new pckeyvalue()
                           {
                               PC_KEY = emp.PC_KEY,
                               VALUE = emp.VALUE
                           };
            List<pckeyvalue> empList = empQuery.ToList();
            return empList;

        }
        public static List<pckeyvalue> getlistofrehabcamping()
        {

            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = from emp in Ganesh.Campings

                           select new pckeyvalue()
                           {
                               PC_KEY = emp.PC_KEY,
                               VALUE = emp.VALUE
                           };
            List<pckeyvalue> empList = empQuery.ToList();
            return empList;
        }
        public static List<pckeyvalue> getlistofMTHREST()
        {

            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = from emp in Ganesh.MTheRests

                           select new pckeyvalue()
                           {
                               PC_KEY = (int)emp.PC_KEY,
                               VALUE = emp.VALUE
                           };
            List<pckeyvalue> empList = empQuery.ToList();
            return empList;
        }
        public static List<pckeyvalue> getlistofmtourism()
        {

            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = from emp in Ganesh.MTourism

                           select new pckeyvalue()
                           {
                               PC_KEY = (int)emp.PC_KEY,
                               VALUE = emp.VALUE
                           };
            List<pckeyvalue> empList = empQuery.ToList();
            return empList;
        }
        public static List<pckeyvalue> getlistofmcapital()
        {

            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = from emp in Ganesh.MCapitals

                           select new pckeyvalue()
                           {
                               PC_KEY = (int)emp.PC_KEY,
                               VALUE = emp.VALUE
                           };
            List<pckeyvalue> empList = empQuery.ToList();
            return empList;
        }
        public static List<pckeyvalue> getlistoflodging()
        {

            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = from emp in Ganesh.Lodgings

                           select new pckeyvalue()
                           {
                               PC_KEY = (int)emp.PC_KEY,
                               VALUE = emp.VALUE
                           };
            List<pckeyvalue> empList = empQuery.ToList();
            return empList;
        }
        public static List<pckeyvalue> getlistfriendsandfamily()
        {

            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = from emp in Ganesh.Friends_and_Families

                           select new pckeyvalue()
                           {
                               PC_KEY = (int)emp.PC_KEY,
                               VALUE = emp.VALUE
                           };
            List<pckeyvalue> empList = empQuery.ToList();
            return empList;
        }
        public static GeneralInfo getfirstvaluogf_from_GeneralInfo()
        {

            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = (from emp in Ganesh.GeneralInfoes
                            select emp).FirstOrDefault();

            return empQuery;
        }

        public static double? getfirstvaluogfDollarsPerFTE_from_GeneralInfo()
        {
            double? x = 0;
            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = (from emp in Ganesh.GeneralInfoes
                            select emp).FirstOrDefault();
            x = empQuery.DollarsPerFTE;
            return x;
        }

        public static double[] getlistof1to17columnsvaluesin160row_Distribution()
        {
            double[] li = new double[18];
            for (int i = 0; i < 18; i++)
                li[i] = 0;
            PEIEntities7 Ganesh = new PEIEntities7();
            Distribution empQuery = (from v in Ganesh.Distributions
                                     where v.ID == 160
                                     select v).FirstOrDefault();
            // Ganesh.Distributions.Where(p => p.ID == 160);

            if (1 < 2)
            {
                li[0] = empQuery.C0 ?? 0;
                li[1] = empQuery.C1 ?? 0;
                li[2] = empQuery.C2 ?? 0;
                li[3] = empQuery.C3 ?? 0;
                li[4] = empQuery.C4 ?? 0;
                li[5] = empQuery.C5 ?? 0;
                li[6] = empQuery.C6 ?? 0;
                li[7] = empQuery.C7 ?? 0;
                li[8] = empQuery.C8 ?? 0;
                li[9] = empQuery.C9 ?? 0;
                li[10] = empQuery.C10 ?? 0;
                li[11] = empQuery.C11 ?? 0;
                li[12] = empQuery.C12 ?? 0;
                li[13] = empQuery.C13 ?? 0;
                li[14] = empQuery.C14 ?? 0;
                li[15] = empQuery.C15 ?? 0;
                li[16] = empQuery.C16 ?? 0;
                li[17] = empQuery.C17 ?? 0;



            }
            return li;
        }

        public static double[] getlistofcolumnnameis0to17columnsvaluesfrom_GeneralInfo()
        {
            double[] li = new double[18];
            for (int i = 0; i < 18; i++)
                li[i] = 0;
            PEIEntities7 Ganesh = new PEIEntities7();

            GeneralInfo empQuery = Ganesh.GeneralInfoes.FirstOrDefault();
            if (1 < 2)
            {
                li[0] = empQuery.C0 ?? 0;
                li[1] = empQuery.C1 ?? 0;
                li[2] = empQuery.C2 ?? 0;
                li[3] = empQuery.C3 ?? 0;
                li[4] = empQuery.C4 ?? 0;
                li[5] = empQuery.C5 ?? 0;
                li[6] = empQuery.C6 ?? 0;
                li[7] = empQuery.C7 ?? 0;
                li[8] = empQuery.C8 ?? 0;
                li[9] = empQuery.C9 ?? 0;
                li[10] = empQuery.C10 ?? 0;
                li[11] = empQuery.C11 ?? 0;
                li[12] = empQuery.C12 ?? 0;
                li[13] = empQuery.C13 ?? 0;
                li[14] = empQuery.C14 ?? 0;
                li[15] = empQuery.C15 ?? 0;
                li[16] = empQuery.C16 ?? 0;
                li[17] = empQuery.C17 ?? 0;



            }
            return li;
        }
        public static List<ZNewIoCode> getiocode_id_and_keyfound(int i)
        {
            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = from emp in Ganesh.ZNewIoCodes
                           where emp.PC_KEY == i
                           select emp;
            List<ZNewIoCode> empList = empQuery.ToList();
            return empList;
        }
        public static List<ZNewIoCode> getiocode_id_and_keyfound()
        {
            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = from emp in Ganesh.ZNewIoCodes
                           orderby emp.ID
                           select emp;
            List<ZNewIoCode> empList = empQuery.ToList();
            return empList;
        }

        public static List<regionclassp> getRIOandp_orderbyRIO_from_defaultdata(string regionname)
        {
            PEIEntities7 Ganesh = new PEIEntities7();
            List<regionclassp> empList = null;
            //var v = (from c in Ganesh.spAlabama_DefaultData(regionname + "_DefaultData").ToList()
            //        orderby c.RIO
            //        select new regionclassp { p = c.P }
            //        ).ToList();
            if (regionname != null)
            {
                empList = (from emp in Ganesh.spAlabama_DefaultData(regionname + "_DefaultData").ToList()//Ganesh.Alabama_DefaultData
                           orderby emp.RIO
                           select new regionclassp { p = emp.P }).ToList(); ;
                // empList = empQuery.ToList();
            }

            return empList;
        }
        public static List<regionclassp> getRIOandp_orderbyRIO_from_defaultdata()
        {
            PEIEntities7 Ganesh = new PEIEntities7();
            List<regionclassp> empList = null;

            empList = (from emp in Ganesh.DefaultDatas
                       orderby emp.RIO
                       select new regionclassp { p = emp.P }

                       ).ToList(); ;
            // empList = empQuery.ToList();


            return empList;
        }

        public static List<LeontievInversegeneric> getalldatafor_LeontievInverse(String regionname)
        {
            PEIEntities7 Ganesh = new PEIEntities7();
            List<LeontievInversegeneric> empList = null;
            if (regionname != null)
            {
                var empQuery = from emp in Ganesh.spAlabama_LeontievInverse(regionname + "_LeontievInverse").ToList()//Ganesh.Alabama_LeontievInverse
                               select new LeontievInversegeneric { ID = emp.ID, VALUE = emp.VALUE };
                empList = empQuery.ToList();
            }

            return empList;

        }


        public static double[,] getdefaultdataon_rio_inc(string regionname)
        {
            double[,] loc = new double[519, 2];
            for (int i = 0; i < 519; i++) { loc[i, 0] = 0; loc[i, 1] = 0; }
            PEIEntities7 Ganesh = new PEIEntities7();
            List<generic_DefaultData> empList = null;
            if (regionname != null)
            {
                var empQuery = from emp in Ganesh.spAlabama_DefaultData(regionname + "_DefaultData").ToList()//Ganesh.Alabama_DefaultData
                               select new generic_DefaultData { RIO = emp.RIO, Inc = emp.Inc, GDP = emp.GDP, Emp = emp.Emp };
                empList = empQuery.ToList();
                int i = 0;
                foreach (var e in empList)
                {
                    loc[i, 0] = e.RIO ?? default(double);
                    loc[i, 1] = e.Inc ?? default(double);
                    i++;
                }
            }

            return loc;
        }

        public static double[,] getdefaultdataon_rio_emp(string regionname)
        {
            double[,] loc = new double[519, 2];
            for (int i = 0; i < 519; i++) { loc[i, 0] = 0; loc[i, 1] = 0; }
            PEIEntities7 Ganesh = new PEIEntities7();
            List<generic_DefaultData> empList = null;
            if (regionname != null)
            {
                var empQuery = from emp in Ganesh.spAlabama_DefaultData(regionname + "_DefaultData").ToList()//Ganesh.Alabama_DefaultData
                               select new generic_DefaultData { RIO = emp.RIO, Inc = emp.Inc, GDP = emp.GDP, Emp = emp.Emp };
                empList = empQuery.ToList();
                int i = 0;
                foreach (var e in empList)
                {
                    loc[i, 0] = e.RIO ?? default(double);
                    loc[i, 1] = e.Emp ?? default(double);
                    i++;
                }
            }

            return loc;
        }

        public static double[,] getdefaultdataon_rio_gdp(string regionname)
        {
            double[,] loc = new double[519, 2];
            for (int i = 0; i < 519; i++) { loc[i, 0] = 0; loc[i, 1] = 0; }
            PEIEntities7 Ganesh = new PEIEntities7();
            List<generic_DefaultData> empList = null;
            if (regionname != null)
            {
                var empQuery = from emp in Ganesh.spAlabama_DefaultData(regionname + "_DefaultData").ToList()//Ganesh.Alabama_DefaultData
                               select new generic_DefaultData { RIO = emp.RIO, Inc = emp.Inc, GDP = emp.GDP };
                empList = empQuery.ToList();
                int i = 0;
                foreach (var e in empList)
                {
                    loc[i, 0] = e.RIO ?? default(double);
                    loc[i, 1] = e.GDP ?? default(double);
                    i++;
                }
            }

            return loc;
        }

        public static List<tempclass> getidandpfrompnationasfirstsecond()
        {

            PEIEntities7 Ganesh = new PEIEntities7();
            List<tempclass> empList = null;

            var empQuery = from emp in Ganesh.P_nation_
                           select new tempclass { first = emp.ID, second = emp.P };
            empList = empQuery.ToList();



            return empList;
        }
        public static List<generic_DefaultData> getdefaultrecordsnoorder(String regionname)
        {
            PEIEntities7 Ganesh = new PEIEntities7();
            List<generic_DefaultData> empList = null;
            if (regionname != null)
            {
                var empQuery = from emp in Ganesh.spAlabama_DefaultData(regionname + "_DefaultData").ToList()//Ganesh.Alabama_DefaultData

                               select new generic_DefaultData
                               {
                                   RIO = emp.RIO,
                                   RIO_KEY = emp.RIO_KEY,
                                   RIO_DESC = emp.RIO_DESC,
                                   REGION_ID = emp.REGION_ID,
                                   Inc = emp.Inc,
                                   Emp = emp.Emp,
                                   GDP = emp.GDP,
                                   Wages = emp.Wages,
                                   P = emp.P,
                                   FederalGen = emp.FederalGen,
                                   FederalIns = emp.FederalIns,
                                   State = emp.State,
                                   Local = emp.Local,
                                   Supply = emp.Supply,
                                   Demand = emp.Demand,
                                   IncomeTotal = emp.IncomeTotal,
                                   EmploymentTotal = emp.EmploymentTotal,
                                   GDPTotal = emp.GDPTotal,
                                   LocalTotal = emp.LocalTotal,
                                   StateTotal = emp.StateTotal,
                                   FederalGenTotal = emp.FederalGenTotal

                               };
                empList = empQuery.ToList();

            }
            return empList;
        }
        public static List<generic_DefaultData> getdefaultrecords(String regionname)
        {
            PEIEntities7 Ganesh = new PEIEntities7();
            List<generic_DefaultData> empList = null;
            if (regionname.Substring(regionname.Length - 4) != "Rest")
            {
                var empQuery = from emp in Ganesh.spAlabama_DefaultData(regionname + "_DefaultData").ToList() //Ganesh.Alabama_DefaultData
                               orderby emp.RIO
                               select new generic_DefaultData
                               {
                                   RIO = emp.RIO,
                                   RIO_KEY = emp.RIO_KEY,
                                   RIO_DESC = emp.RIO_DESC,
                                   REGION_ID = emp.REGION_ID,
                                   Inc = emp.Inc,
                                   Emp = emp.Emp,
                                   GDP = emp.GDP,
                                   Wages = emp.Wages,
                                   P = emp.P,
                                   FederalGen = emp.FederalGen,
                                   FederalIns = emp.FederalIns,
                                   State = emp.State,
                                   Local = emp.Local,
                                   Supply = emp.Supply,
                                   Demand = emp.Demand,
                                   IncomeTotal = emp.IncomeTotal,
                                   EmploymentTotal = emp.EmploymentTotal,
                                   GDPTotal = emp.GDPTotal,
                                   LocalTotal = emp.LocalTotal,
                                   StateTotal = emp.StateTotal,
                                   FederalGenTotal = emp.FederalGenTotal

                               };
                empList = empQuery.ToList();

            }

            if (regionname.Substring(regionname.Length - 4) == "Rest")
            {
                var empQuery = from emp in Ganesh.spAlabamaRest_DefaultData(regionname + "_DefaultData").ToList()//Ganesh.AlabamaRest_DefaultData
                               orderby emp.RIO
                               select new generic_DefaultData
                               {
                                   RIO = emp.RIO,
                                   RIO_KEY = emp.RIO_KEY,
                                   RIO_DESC = emp.RIO_DESC,
                                   REGION_ID = emp.REGION_ID,
                                   Inc = emp.Inc,
                                   Emp = emp.Emp,
                                   GDP = emp.GDP,
                                   Wages = emp.Wages,
                                   P = emp.P,
                                   FederalGen = emp.FederalGen,
                                   FederalIns = emp.FederalIns,
                                   State = emp.State,
                                   Local = emp.Local,
                                   Supply = emp.Supply,
                                   Demand = emp.Demand,
                                   IncomeTotal = emp.IncomeTotal,
                                   EmploymentTotal = emp.EmploymentTotal,
                                   GDPTotal = emp.GDPTotal,
                                   LocalTotal = emp.LocalTotal,
                                   StateTotal = emp.StateTotal,
                                   FederalGenTotal = emp.FederalGenTotal

                               };
                empList = empQuery.ToList();

            }
            return empList;
        }
        public static List<generic_DefaultData> getdefaultrecords()
        {
            PEIEntities7 Ganesh = new PEIEntities7();
            List<generic_DefaultData> empList = null;

            var empQuery = from emp in Ganesh.DefaultDatas
                           select new generic_DefaultData
                           {
                               RIO = emp.RIO,
                               RIO_KEY = emp.RIO_KEY,
                               //RIO_DESC = emp.RIO_DESC,
                               REGION_ID = emp.REGION_ID,
                               Inc = emp.Inc,
                               Emp = emp.Emp,
                               GDP = emp.GDP,
                               Wages = emp.Wages,
                               P = emp.P,
                               FederalGen = emp.FederalGen,
                               FederalIns = emp.FederalIns,
                               State = emp.State,
                               Local = emp.Local,
                               Supply = emp.Supply,
                               Demand = emp.Demand,
                               IncomeTotal = emp.IncomeTotal,
                               EmploymentTotal = emp.EmploymentTotal,
                               GDPTotal = emp.GDPTotal,
                               LocalTotal = emp.LocalTotal,
                               StateTotal = emp.StateTotal,
                               FederalGenTotal = emp.FederalGenTotal

                           };
            empList = empQuery.ToList();


            return empList;
        }
        public static List<tblGeneralIndustry> gettblgeneralindustrydatacopiedtolocal()
        {
            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = (from emp in Ganesh.tblGeneralIndustries
                            select emp).ToList();
            return empQuery;

        }



        public static double[] getgeneralindustryrecordasarray()
        {
            double[] li = new double[99];
            for (int i = 0; i < 99; i++)
                li[i] = 0;
            PEIEntities7 Ganesh = new PEIEntities7();

            var xx = Ganesh.tblGeneralIndustries.FirstOrDefault();
            int j = 0;
            double d = 0;
            li[0] = xx.Employment1 ?? default(double);
            li[1] = xx.Employment2 ?? default(double);
            li[2] = xx.Employment3 ?? default(double);
            li[3] = xx.Employment4 ?? default(double);
            li[4] = xx.Employment5 ?? default(double);
            li[5] = xx.Employment6 ?? default(double);
            li[6] = xx.Employment7 ?? default(double);
            li[7] = xx.Employment8 ?? default(double);
            li[8] = xx.Employment9 ?? default(double);
            li[9] = xx.Employment10 ?? default(double);
            li[10] = xx.Employment11 ?? default(double);
            li[11] = xx.Employment12 ?? default(double);
            li[12] = xx.Employment13 ?? default(double);
            li[13] = xx.Employment14 ?? default(double);
            li[14] = xx.Income1 ?? default(double);
            li[15] = xx.Income2 ?? default(double);
            li[16] = xx.Income3 ?? default(double);
            li[17] = xx.Income4 ?? default(double);
            li[18] = xx.Income5 ?? default(double);
            li[19] = xx.Income6 ?? default(double);
            li[20] = xx.Income7 ?? default(double);
            li[21] = xx.Income8 ?? default(double);
            li[22] = xx.Income9 ?? default(double);
            li[23] = xx.Income10 ?? default(double);
            li[24] = xx.Income11 ?? default(double);
            li[25] = xx.Income12 ?? default(double);
            li[26] = xx.Income13 ?? default(double);
            li[27] = xx.Income14 ?? default(double);
            li[28] = xx.Gross1 ?? default(double);
            li[29] = xx.Gross2 ?? default(double);
            li[30] = xx.Gross3 ?? default(double);
            li[31] = xx.Gross4 ?? default(double);
            li[32] = xx.Gross5 ?? default(double);
            li[33] = xx.Gross6 ?? default(double);
            li[34] = xx.Gross7 ?? default(double);
            li[35] = xx.Gross8 ?? default(double);
            li[36] = xx.Gross9 ?? default(double);
            li[37] = xx.Gross10 ?? default(double);
            li[38] = xx.Gross11 ?? default(double);
            li[39] = xx.Gross12 ?? default(double);
            li[40] = xx.Gross13 ?? default(double);
            li[41] = xx.Gross14 ?? default(double);
            li[42] = xx.Gross15 ?? default(double);
            li[43] = xx.Gross16 ?? default(double);
            li[44] = xx.Gross17 ?? default(double);
            li[45] = xx.Gross18 ?? default(double);
            li[46] = xx.Gross19 ?? default(double);
            li[47] = xx.Gross20 ?? default(double);
            li[48] = xx.Gross21 ?? default(double);
            li[49] = xx.Gross22 ?? default(double);
            li[50] = xx.Gross23 ?? default(double);
            li[51] = xx.Gross24 ?? default(double);
            li[52] = xx.Gross25 ?? default(double);
            li[53] = xx.Output1 ?? default(double);
            li[54] = xx.Output2 ?? default(double);
            li[55] = xx.Output3 ?? default(double);
            li[56] = xx.Output4 ?? default(double);
            li[57] = xx.Output5 ?? default(double);
            li[58] = xx.Output6 ?? default(double);
            li[59] = xx.Output7 ?? default(double);
            li[60] = xx.Output8 ?? default(double);
            li[61] = xx.Output9 ?? default(double);
            li[62] = xx.Output10 ?? default(double);
            li[63] = xx.Output11 ?? default(double);
            li[64] = xx.Output12 ?? default(double);
            li[65] = xx.Output13 ?? default(double);
            li[66] = xx.Output14 ?? default(double);
            li[67] = xx.InitialEffect ?? default(double);
            li[68] = xx.Gross26 ?? default(double);
            li[69] = xx.Gross27 ?? default(double);
            li[70] = xx.Gross28 ?? default(double);
            li[71] = xx.Gross29 ?? default(double);
            li[72] = xx.Gross30 ?? default(double);
            li[73] = xx.PersonalIncome ?? default(double);



            return li;
        }
        public static double[] getgeneralindustryrecordasarrayfromobj(tblGeneralIndustry xx)
        {
            double[] li = new double[99];
            for (int i = 0; i < 99; i++)
                li[i] = 0;
            //PEIEntities7 Ganesh = new PEIEntities7();

            //var xx = Ganesh.tblGeneralIndustries.FirstOrDefault();
            int j = 0;
            double d = 0;
            li[0] = xx.Employment1 ?? default(double);
            li[1] = xx.Employment2 ?? default(double);
            li[2] = xx.Employment3 ?? default(double);
            li[3] = xx.Employment4 ?? default(double);
            li[4] = xx.Employment5 ?? default(double);
            li[5] = xx.Employment6 ?? default(double);
            li[6] = xx.Employment7 ?? default(double);
            li[7] = xx.Employment8 ?? default(double);
            li[8] = xx.Employment9 ?? default(double);
            li[9] = xx.Employment10 ?? default(double);
            li[10] = xx.Employment11 ?? default(double);
            li[11] = xx.Employment12 ?? default(double);
            li[12] = xx.Employment13 ?? default(double);
            li[13] = xx.Employment14 ?? default(double);
            li[14] = xx.Income1 ?? default(double);
            li[15] = xx.Income2 ?? default(double);
            li[16] = xx.Income3 ?? default(double);
            li[17] = xx.Income4 ?? default(double);
            li[18] = xx.Income5 ?? default(double);
            li[19] = xx.Income6 ?? default(double);
            li[20] = xx.Income7 ?? default(double);
            li[21] = xx.Income8 ?? default(double);
            li[22] = xx.Income9 ?? default(double);
            li[23] = xx.Income10 ?? default(double);
            li[24] = xx.Income11 ?? default(double);
            li[25] = xx.Income12 ?? default(double);
            li[26] = xx.Income13 ?? default(double);
            li[27] = xx.Income14 ?? default(double);
            li[28] = xx.Gross1 ?? default(double);
            li[29] = xx.Gross2 ?? default(double);
            li[30] = xx.Gross3 ?? default(double);
            li[31] = xx.Gross4 ?? default(double);
            li[32] = xx.Gross5 ?? default(double);
            li[33] = xx.Gross6 ?? default(double);
            li[34] = xx.Gross7 ?? default(double);
            li[35] = xx.Gross8 ?? default(double);
            li[36] = xx.Gross9 ?? default(double);
            li[37] = xx.Gross10 ?? default(double);
            li[38] = xx.Gross11 ?? default(double);
            li[39] = xx.Gross12 ?? default(double);
            li[40] = xx.Gross13 ?? default(double);
            li[41] = xx.Gross14 ?? default(double);
            li[42] = xx.Gross15 ?? default(double);
            li[43] = xx.Gross16 ?? default(double);
            li[44] = xx.Gross17 ?? default(double);
            li[45] = xx.Gross18 ?? default(double);
            li[46] = xx.Gross19 ?? default(double);
            li[47] = xx.Gross20 ?? default(double);
            li[48] = xx.Gross21 ?? default(double);
            li[49] = xx.Gross22 ?? default(double);
            li[50] = xx.Gross23 ?? default(double);
            li[51] = xx.Gross24 ?? default(double);
            li[52] = xx.Gross25 ?? default(double);
            li[53] = xx.Output1 ?? default(double);
            li[54] = xx.Output2 ?? default(double);
            li[55] = xx.Output3 ?? default(double);
            li[56] = xx.Output4 ?? default(double);
            li[57] = xx.Output5 ?? default(double);
            li[58] = xx.Output6 ?? default(double);
            li[59] = xx.Output7 ?? default(double);
            li[60] = xx.Output8 ?? default(double);
            li[61] = xx.Output9 ?? default(double);
            li[62] = xx.Output10 ?? default(double);
            li[63] = xx.Output11 ?? default(double);
            li[64] = xx.Output12 ?? default(double);
            li[65] = xx.Output13 ?? default(double);
            li[66] = xx.Output14 ?? default(double);
            li[67] = xx.InitialEffect ?? default(double);
            li[68] = xx.Gross26 ?? default(double);
            li[69] = xx.Gross27 ?? default(double);
            li[70] = xx.Gross28 ?? default(double);
            li[71] = xx.Gross29 ?? default(double);
            li[72] = xx.Gross30 ?? default(double);
            li[73] = xx.PersonalIncome ?? default(double);



            return li;
        }
        public static double[] geteconomicbaseasarrayfromobj(tblEconomicBase xx)
        {
            double[] li = new double[44];
            for (int i = 0; i < 44; i++)
                li[i] = 0;

            int j = 0;

            li[0] = xx.Employment1 ?? default(double);
            li[1] = xx.Employment2 ?? default(double);
            li[2] = xx.Employment3 ?? default(double);
            li[3] = xx.Employment4 ?? default(double);
            li[4] = xx.Employment5 ?? default(double);
            li[5] = xx.Employment6 ?? default(double);
            li[6] = xx.Employment7 ?? default(double);
            li[7] = xx.Employment8 ?? default(double);
            li[8] = xx.Employment9 ?? default(double);
            li[9] = xx.Employment10 ?? default(double);
            li[10] = xx.Employment11 ?? default(double);
            li[11] = xx.Income1 ?? default(double);
            li[12] = xx.Income2 ?? default(double);
            li[13] = xx.Income3 ?? default(double);
            li[14] = xx.Income4 ?? default(double);
            li[15] = xx.Income5 ?? default(double);
            li[16] = xx.Income6 ?? default(double);
            li[17] = xx.Income7 ?? default(double);
            li[18] = xx.Income8 ?? default(double);
            li[19] = xx.Income9 ?? default(double);
            li[20] = xx.Income10 ?? default(double);
            li[21] = xx.Income11 ?? default(double);
            li[22] = xx.Gross1 ?? default(double);
            li[23] = xx.Gross2 ?? default(double);
            li[24] = xx.Gross3 ?? default(double);
            li[25] = xx.Gross4 ?? default(double);
            li[26] = xx.Gross5 ?? default(double);
            li[27] = xx.Gross6 ?? default(double);
            li[28] = xx.Gross7 ?? default(double);
            li[29] = xx.Gross8 ?? default(double);
            li[30] = xx.Gross9 ?? default(double);
            li[31] = xx.Gross10 ?? default(double);
            li[32] = xx.Gross11 ?? default(double);
            li[33] = xx.Output1 ?? default(double);
            li[34] = xx.Output2 ?? default(double);
            li[35] = xx.Output3 ?? default(double);
            li[36] = xx.Output4 ?? default(double);
            li[37] = xx.Output5 ?? default(double);
            li[38] = xx.Output6 ?? default(double);
            li[39] = xx.Output7 ?? default(double);
            li[40] = xx.Output8 ?? default(double);
            li[41] = xx.Output9 ?? default(double);
            li[42] = xx.Output10 ?? default(double);
            li[43] = xx.Output11 ?? default(double);

            return li;
        }
        public static double[] geteconomicbaseasarray()
        {
            double[] li = new double[44];
            for (int i = 0; i < 44; i++)
                li[i] = 0;
            PEIEntities7 Ganesh = new PEIEntities7();

            var xx = Ganesh.tblEconomicBases.FirstOrDefault();
            int j = 0;

            li[0] = xx.Employment1 ?? default(double);
            li[1] = xx.Employment2 ?? default(double);
            li[2] = xx.Employment3 ?? default(double);
            li[3] = xx.Employment4 ?? default(double);
            li[4] = xx.Employment5 ?? default(double);
            li[5] = xx.Employment6 ?? default(double);
            li[6] = xx.Employment7 ?? default(double);
            li[7] = xx.Employment8 ?? default(double);
            li[8] = xx.Employment9 ?? default(double);
            li[9] = xx.Employment10 ?? default(double);
            li[10] = xx.Employment11 ?? default(double);
            li[11] = xx.Income1 ?? default(double);
            li[12] = xx.Income2 ?? default(double);
            li[13] = xx.Income3 ?? default(double);
            li[14] = xx.Income4 ?? default(double);
            li[15] = xx.Income5 ?? default(double);
            li[16] = xx.Income6 ?? default(double);
            li[17] = xx.Income7 ?? default(double);
            li[18] = xx.Income8 ?? default(double);
            li[19] = xx.Income9 ?? default(double);
            li[20] = xx.Income10 ?? default(double);
            li[21] = xx.Income11 ?? default(double);
            li[22] = xx.Gross1 ?? default(double);
            li[23] = xx.Gross2 ?? default(double);
            li[24] = xx.Gross3 ?? default(double);
            li[25] = xx.Gross4 ?? default(double);
            li[26] = xx.Gross5 ?? default(double);
            li[27] = xx.Gross6 ?? default(double);
            li[28] = xx.Gross7 ?? default(double);
            li[29] = xx.Gross8 ?? default(double);
            li[30] = xx.Gross9 ?? default(double);
            li[31] = xx.Gross10 ?? default(double);
            li[32] = xx.Gross11 ?? default(double);
            li[33] = xx.Output1 ?? default(double);
            li[34] = xx.Output2 ?? default(double);
            li[35] = xx.Output3 ?? default(double);
            li[36] = xx.Output4 ?? default(double);
            li[37] = xx.Output5 ?? default(double);
            li[38] = xx.Output6 ?? default(double);
            li[39] = xx.Output7 ?? default(double);
            li[40] = xx.Output8 ?? default(double);
            li[41] = xx.Output9 ?? default(double);
            li[42] = xx.Output10 ?? default(double);
            li[43] = xx.Output11 ?? default(double);

            return li;
        }

        public static tblIndustry gettbinduustryobjectbySIC(int i)
        {
            tblIndustry empQuery = null;
            PEIEntities7 Ganesh = new PEIEntities7();

            empQuery = Ganesh.tblIndustries.Where(o => o.SIC.Value.Equals(i)).FirstOrDefault();

            return empQuery;
        }

        public static List<OccupationDistribution> getallOccupationDistributionrecordsorderbyid()
        {
            List<OccupationDistribution> empQuery = null;
            PEIEntities7 Ganesh = new PEIEntities7();

            empQuery = Ganesh.OccupationDistributions.ToList();//.OrderBy(p=>p.OccupationID)

            return empQuery;
        }

        public static List<tblOccupation> getallOccupationecordsorderbyid()
        {
            List<tblOccupation> empQuery = null;
            PEIEntities7 Ganesh = new PEIEntities7();

            empQuery = Ganesh.tblOccupations.ToList();//.OrderBy(p => p.OccupationID)

            return empQuery;
        }



        public static double[] getpopulationcolumnasarrayfromAreatablesofallregions(string region_name)
        {
            double[] two = new double[2];
            PEIEntities7 Ganesh = new PEIEntities7();
            // var v=Ganesh.spAlabama_Area("alabama");
            if (region_name != null)
            {
                //two[1] = Ganesh.Alabama_Area.FirstOrDefault().Population ?? default(double);
                //two[0] = Ganesh.AlabamaRest_Area.FirstOrDefault().Population ?? default(double);
                two[1] = Ganesh.spAlabama_Area(region_name + "_Area").ToList().FirstOrDefault().Population ?? default(double);
                two[0] = Ganesh.spAlabamaRest_Area(region_name + "Rest_Area").ToList().FirstOrDefault().Population ?? default(double);

            }
            return two;
        }

        public static List<generic_AMatrix> getregioanlamtrix(string region_name)
        {

            PEIEntities7 Ganesh = new PEIEntities7();
            List<generic_AMatrix> empList = null;
            if (region_name.Substring(region_name.Length - 4) != "Rest")
            {
                var empQuery = from emp in Ganesh.spAlabama_AMatrix(region_name + "_AMatrix ").ToList()//Ganesh.Alabama_AMatrix   
                               select new generic_AMatrix { ID = emp.ID, VALUE = emp.VALUE };
                empList = empQuery.ToList();
            }
            if (region_name.Substring(region_name.Length - 4) == "Rest")//instead of name check last 4 letters rest
            {
                if (region_name == "AlabamaRest") region_name = "Z_" + region_name;//special cas for labama
                //region  abalama rest table a bitterent name given
                var empQuery = from emp in Ganesh.spz_AlabamaRest_AMatrix(region_name + "_AMatrix ").ToList() //Ganesh.z_AlabamaRest_AMatrix   //z_AlabamaRest_AMatrix
                               select new generic_AMatrix { ID = emp.ID, VALUE = emp.VALUE };
                empList = empQuery.ToList();
            }

            return empList;
        }

        public static List<JointVenture> getlistofidandvalue_JointVentures()
        {
            PEIEntities7 Ganesh = new PEIEntities7();
            var empQuery = (from emp in Ganesh.JointVentures
                            select emp).ToList();
            return empQuery;
        }
    }
    public class pckeyvalue
    {
        public int? PC_KEY { set; get; }
        public double? VALUE { set; get; }
    }
    public class tempclass
    {
        public double? first { set; get; }
        public double? second { set; get; }
    }

    public class joinedcalss
    {
        public Nullable<double> ID { get; set; }
        public Nullable<int> SIC { get; set; }
        public Nullable<double> Employment { get; set; }
        public Nullable<double> Income { get; set; }
        public Nullable<double> GDP { get; set; }
        public Nullable<double> Output { get; set; }

    }


    public class regionclassp
    {

        public double? p { set; get; }
    }
    public class LeontievInversegeneric
    {
        public Nullable<int> ID { get; set; }
        public Nullable<double> VALUE { get; set; }
    }

    public class generic_DefaultData
    {
        public Nullable<int> RIO { get; set; }
        public Nullable<int> RIO_KEY { get; set; }
        public string RIO_DESC { get; set; }
        public Nullable<int> REGION_ID { get; set; }
        public Nullable<double> Inc { get; set; }
        public Nullable<double> Emp { get; set; }
        public Nullable<double> GDP { get; set; }
        public Nullable<double> Wages { get; set; }
        public Nullable<double> P { get; set; }
        public Nullable<double> FederalGen { get; set; }
        public Nullable<double> FederalIns { get; set; }
        public Nullable<double> State { get; set; }
        public Nullable<double> Local { get; set; }
        public Nullable<double> Supply { get; set; }
        public Nullable<double> Demand { get; set; }
        public Nullable<double> IncomeTotal { get; set; }
        public Nullable<double> EmploymentTotal { get; set; }
        public Nullable<double> GDPTotal { get; set; }
        public Nullable<double> LocalTotal { get; set; }
        public Nullable<double> StateTotal { get; set; }
        public Nullable<double> FederalGenTotal { get; set; }
        public Nullable<short> Locked { get; set; }

    }

    public class generic_AMatrix
    {
        public int ID { get; set; }
        public Nullable<double> VALUE { get; set; }

    }

    public class tblIndustryreport
    {
        public string key { set; get; }

        public List<Industrylocal> groupl;


    }
    public class Industrylocal
    {
        public string Industry { get; set; }
        public Nullable<int> IndustryID { get; set; }
        public string Section { get; set; }
        public Nullable<int> SectionID { get; set; }
        public Nullable<double> Employment { get; set; }
        public Nullable<double> Income { get; set; }
        public Nullable<double> GrossStateProduct { get; set; }
        public Nullable<double> Output { get; set; }

    }

    public class historymodelview
    {
        public string logid { get; set; }
        public string datetime { get; set; }
        public string region { get; set; }
        public string  country { get; set; }
    }

}