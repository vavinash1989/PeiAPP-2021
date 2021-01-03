
    using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using PEIaPP.Models;
namespace PEIaPP.Controllers
{
    public class UIdata
    {
        public double region { set; get; }
        public double report { set; get; }
        public string country { set; get; }

        public bool tab1 { set; get; }
        public bool tab2 { set; get; }
        public bool tab3 { set; get; }
        public bool tab4 { set; get; }

        public double MainCR { set; get; }
        public double MainCNC { set; get; }
        public double CJV { set; get; }
        public double MainJNCB { set; get; }
        public double HMS { set; get; }
        public double tcs { set; get; }
        public double vc { set; get; }
        public bool three1 { set; get; }
        public double three2 { set; get; }
        public double three3 { set; get; }
        public bool three4 { set; get; }
        public double three5 { set; get; }
        public double three6 { set; get; }
        public double three7 { set; get; }
        public double three8 { set; get; }
        public double three9 { set; get; }
        public double three10 { set; get; }
        public double three11 { set; get; }
        public bool rmaina { set; get; }
        public bool rmainb { set; get; }
        public bool rmainc { set; get; }
        public bool rmaind { set; get; }
        public double r1a { set; get; }
        public double r2a { set; get; }
        public double r3a { set; get; }
        public double r4a { set; get; }
        public double r5a { set; get; }
        public double r6a { set; get; }
        public double r7a { set; get; }
        public double r8a { set; get; }
        public double r9a { set; get; }
        public double r10a { set; get; }
        public double r11a { set; get; }
        public double r12a { set; get; }
        public double r13a { set; get; }
        public double r14a { set; get; }
        public double r15a { set; get; }
        public double r16a { set; get; }
        public double r17a { set; get; }
        public double r18a { set; get; }
        public double r19a { set; get; }
        public double r20a { set; get; }
        public double r21a { set; get; }
        public double r22a { set; get; }
        public double r23a { set; get; }
        public double r24a { set; get; }
        public double r25a { set; get; }
        public double r26a { set; get; }
        public double r27a { set; get; }
        public double r28a { set; get; }
        public double r29a { set; get; }
        public double r30a { set; get; }
        public double r31a { set; get; }
        public double r32a { set; get; }
        public double r33a { set; get; }
        public double r34a { set; get; }
        public double r35a { set; get; }
        public double r36a { set; get; }
        public double r37a { set; get; }
        public double r38a { set; get; }
        public double r39a { set; get; }
        public double r40a { set; get; }
        public double r1b { set; get; }
        public double r2b { set; get; }
        public double r3b { set; get; }
        public double r4b { set; get; }
        public double r5b { set; get; }
        public double r6b { set; get; }
        public double r7b { set; get; }
        public double r8b { set; get; }
        public double r9b { set; get; }
        public double r10b { set; get; }
        public double r11b { set; get; }
        public double r12b { set; get; }
        public double r13b { set; get; }
        public double r14b { set; get; }
        public double r15b { set; get; }
        public double r16b { set; get; }
        public double r17b { set; get; }
        public double r18b { set; get; }
        public double r19b { set; get; }
        public double r20b { set; get; }
        public double r21b { set; get; }
        public double r22b { set; get; }
        public double r23b { set; get; }
        public double r24b { set; get; }
        public double r25b { set; get; }
        public double r26b { set; get; }
        public double r27b { set; get; }
        public double r28b { set; get; }
        public double r29b { set; get; }
        public double r30b { set; get; }
        public double r31b { set; get; }
        public double r32b { set; get; }
        public double r33b { set; get; }
        public double r34b { set; get; }
        public double r35b { set; get; }
        public double r36b { set; get; }
        public double r37b { set; get; }
        public double r38b { set; get; }
        public double r39b { set; get; }
        public double r40b { set; get; }
        public double r1c { set; get; }
        public double r2c { set; get; }
        public double r3c { set; get; }
        public double r4c { set; get; }
        public double r5c { set; get; }
        public double r6c { set; get; }
        public double r7c { set; get; }
        public double r8c { set; get; }
        public double r9c { set; get; }
        public double r10c { set; get; }
        public double r11c { set; get; }
        public double r12c { set; get; }
        public double r13c { set; get; }
        public double r14c { set; get; }
        public double r15c { set; get; }
        public double r16c { set; get; }
        public double r17c { set; get; }
        public double r18c { set; get; }
        public double r19c { set; get; }
        public double r20c { set; get; }
        public double r21c { set; get; }
        public double r22c { set; get; }
        public double r23c { set; get; }
        public double r24c { set; get; }
        public double r25c { set; get; }
        public double r26c { set; get; }
        public double r27c { set; get; }
        public double r28c { set; get; }
        public double r29c { set; get; }
        public double r30c { set; get; }
        public double r31c { set; get; }
        public double r32c { set; get; }
        public double r33c { set; get; }
        public double r34c { set; get; }
        public double r35c { set; get; }
        public double r36c { set; get; }
        public double r37c { set; get; }
        public double r38c { set; get; }
        public double r39c { set; get; }
        public double r40c { set; get; }
        public double r1d { set; get; }
        public double r2d { set; get; }
        public double r3d { set; get; }
        public double r4d { set; get; }
        public double r5d { set; get; }
        public double r6d { set; get; }
        public double r7d { set; get; }
        public double r8d { set; get; }
        public double r9d { set; get; }
        public double r10d { set; get; }
        public double r11d { set; get; }
        public double r12d { set; get; }
        public double r13d { set; get; }
        public double r14d { set; get; }
        public double r15d { set; get; }
        public double r16d { set; get; }
        public double r17d { set; get; }
        public double r18d { set; get; }
        public double r19d { set; get; }
        public double r20d { set; get; }
        public double r21d { set; get; }
        public double r22d { set; get; }
        public double r23d { set; get; }
        public double r24d { set; get; }
        public double r25d { set; get; }
        public double r26d { set; get; }
        public double r27d { set; get; }
        public double r28d { set; get; }
        public double r29d { set; get; }
        public double r30d { set; get; }
        public double r31d { set; get; }
        public double r32d { set; get; }
        public double r33d { set; get; }
        public double r34d { set; get; }
        public double r35d { set; get; }
        public double r36d { set; get; }
        public double r37d { set; get; }
        public double r38d { set; get; }
        public double r39d { set; get; }
        public double r40d { set; get; }

    }

    public class Home1Controller : Controller
    {
        //[Authorize]

        public JsonResult getlastrundetails()
        {
            int status = 0;//Convert.ToInt32(Session["recordstatus"].ToString());
            if (status == 0) //new is zero so all values return zero
                return Json(new { three2 = 99, three3 = 0, three5 = 0, three6 = 0, three7 = 0, three8 = 0, three9 = 0, three10 = 0, three11 = 0 }, JsonRequestBehavior.AllowGet);
            else
            {
                var b = Session["record"] as History;
                return Json(new { three2 = b.three2, three3 = 78, three5 = 35, three6 = 58, three7 = 77, three8 = 798, three9 = 3095, three10 = 7822, three11 = 435 }, JsonRequestBehavior.AllowGet);
            }

        }
        public JsonResult getdefaultthree3()
        {
          
                return Json(new { three2 = 35, three3 = 78, three5 = 35, three6 = 58, three7 = 77, three8 = 798, three9 = 3095, three10 = 7822, three11 = 435 }, JsonRequestBehavior.AllowGet);


        }
   //getdefaultone1
   //     $scope.MainCR = data.MainCR;
   //         $scope.MainCNC = data.MainCNC;
   //         $scope.CJV = data.CJV;
   //         $scope.MainJNCB = data.MainJNCB;
        public JsonResult getdefaultone1()
        {
            int res = 66;
            return Json(new { MainCR = 35, MainCNC = 78, CJV = 35, MainJNCB = 58}, JsonRequestBehavior.AllowGet);
        }

 //       getdefaulfour4
 //<input type="button" value="GetDefaultvalues" ng-click="getdefaulfour4()" />

 //           $scope.HMS = data.HMS;
 //           $scope.tcs = data.tcs;
 //           $scope.vc = data.vc;
        public JsonResult getdefaulfour4()
        {
            int res = 66;
            return Json(new { HMS = 35, tcs = 78, vc = 35}, JsonRequestBehavior.AllowGet);
        }
//getdefaultlone1
//<input type="button" value="GetDefaultvalues" ng-click="getdefaultlone1()" />

        public JsonResult getdefaultlone1()
        {
            //r7a=45, r8a=58, r9a=45, r10a=445, r11a=445, r12a=745, r13a=458, r14a=455, r15a=1145, r16a=45, r17a=45, r18a=45, r19a=45, r20a=45, r21a=45, r22a=45, r23a=45, r24a=45,r25a=45, r26a=45, r27a=45, r28a=45, r29a=45, r30a=45, r31a=45, r32a=45, r33a=45, r34a=45, r35a=45, r36a=45, r37a=45, r38a=45, r39a=45, r40a=56
            int res = 66;
            return Json(new { r7a = 45, r8a = 58, r9a = 45, r10a = 445, r11a = 445, r12a = 745, r13a = 458, r14a = 455, r15a = 1145, r16a = 45, r17a = 45, r18a = 45, r19a = 45, r20a = 45, r21a = 45, r22a = 45, r23a = 45, r24a = 45, r25a = 45, r26a = 45, r27a = 45, r28a = 45, r29a = 45, r30a = 45, r31a = 45, r32a = 45, r33a = 45, r34a = 45, r35a = 45, r36a = 45, r37a = 45, r38a = 45, r39a = 45, r40a = 56 }, JsonRequestBehavior.AllowGet);
        }

//getdefaultltwo2
//<input type="button" value="GetDefaultvalues" ng-click="getdefaultltwo2()" />
        public JsonResult getdefaultltwo2()
        {
            int res = 66;
            return Json(new { r7b = 45, r8b = 58, r9b = 45, r10b = 445, r11b = 445, r12b = 745, r13b = 458, r14b = 455, r15b = 1145, r16b = 45, r17b = 45, r18b = 45, r19b = 45, r20b = 45, r21b = 45, r22b = 45, r23b = 45, r24b = 45, r25b = 45, r26b = 45, r27b = 45, r28b = 45, r29b = 45, r30b = 45, r31b = 45, r32b = 45, r33b = 45, r34b = 45, r35b = 45, r36b = 45, r37b = 45, r38b = 45, r39b = 45, r40b = 56 }, JsonRequestBehavior.AllowGet);
        }
//        getdefaultlthree3
//<input type="button" value="GetDefaultvalues" ng-click="getdefaultlthree3()" />
        public JsonResult getdefaultlthree3()
        {
            int res = 66;
            return Json(new { r7c = 45, r8c = 58, r9c = 45, r10c = 445, r11c = 445, r12c = 745, r13c = 458, r14c = 455, r15c = 1145, r16c = 45, r17c = 45, r18c = 45, r19c = 45, r20c = 45, r21c = 45, r22c = 45, r23c = 45, r24c = 45, r25c = 45, r26c = 45, r27c = 45, r28c = 45, r29c = 45, r30c = 45, r31c = 45, r32c = 45, r33c = 45, r34c = 45, r35c = 45, r36c = 45, r37c = 45, r38c = 45, r39c = 45, r40c = 56 }, JsonRequestBehavior.AllowGet);
        }
//        getdefaultlfour4
//<input type="button" value="GetDefaultvalues" ng-click="getdefaultlfour4()" />

        public JsonResult getdefaultlfour4()
        {
            int res = 66;
            return Json(new { r7d = 45, r8d = 58, r9d = 45, r10d = 445, r11d = 445, r12d = 745, r13d = 458, r14d = 455, r15d = 1145, r16d = 45, r17d = 45, r18d = 45, r19d = 45, r20d = 45, r21d = 45, r22d = 45, r23d = 45, r24d = 45, r25d = 45, r26d = 45, r27d = 45, r28d = 45, r29d = 45, r30d = 45, r31d = 45, r32d = 45, r33d = 45, r34d = 45, r35d = 45, r36d = 45, r37d = 45, r38d = 45, r39d = 45, r40d = 56 }, JsonRequestBehavior.AllowGet);
        }

        private  int recordnew;

        //[Authorize]
        [System.Web.Mvc.HttpGet]
        public ActionResult Index()
        {
            Session["recordstatus"] = 0;
            return View();
        }
        //[Authorize]
         [System.Web.Mvc.HttpPost]
        public ActionResult Index(int id)
        {
            Session["recordstatus"] = 1;
          
            Session["record"] = repository.getselectedrecord(id);
            //var v = repository.getuserhistory(user);
            //List<historymodelview> userhistory = v;
            //return View(userhistory);

            return View();
        }
        public void Savebasicinfo(string country, int state, int region)
        {

         //       string state, int country, int region
            Session["country"] = country;
            Session["state"] = state;
            Session["region"] = region;
            
        }
        public string jg(UIdata udata)
        {
            return "Jai Ganesh";
        }
        public String Login(Login login)
        {
            return "Jai Ganesh";
        }
        public FileResult report1()
        {
            List<tblEconomicBase> xxx = (List<tblEconomicBase>)(Session["economy"]);
            tblEconomicBase gg = xxx[0];
            string[] lab = new string[10];
            double[] output = new double[10];
            double[] Employment = new double[10];
            double[] Income = new double[10];
            double[] Gross = new double[10];

            lab[0] = "Agriculture";

            lab[1] = "agre save forest and Fresh";
            lab[2] = "Mining";
            lab[3] = "construction";
            lab[4] = "transportation";
            lab[5] = "wholesale";
            lab[6] = "rateil trade";
            lab[7]="services";
            lab[8] = "wholesale";
            lab[9] = "Real estate";

            output[0] = gg.Output1 ?? 0;
            output[1] = gg.Output2 ?? 0;
            output[2] = gg.Output3 ?? 0;
            output[3] = gg.Output4 ?? 0;
            output[4] = gg.Output5 ?? 0;
            output[5] = gg.Output6 ?? 0;
            output[6] = gg.Output7 ?? 0;
            output[7] = gg.Output8 ?? 0;
            output[8] = gg.Output9 ?? 0;
            output[9] = gg.Output10 ?? 0;

            Employment[0] = gg.Employment1 ?? 0;
            Employment[1] = gg.Employment2 ?? 0;
            Employment[2] = gg.Employment3 ?? 0;
            Employment[3] = gg.Employment4 ?? 0;
            Employment[4] = gg.Employment5 ?? 0;
            Employment[5] = gg.Employment6 ?? 0;
            Employment[6] = gg.Employment7 ?? 0;
            Employment[7] = gg.Employment8 ?? 0;
            Employment[8] = gg.Employment9 ?? 0;
            Employment[9] = gg.Employment10 ?? 0;

            Gross[0] = gg.Gross1 ?? 0;
            Gross[1] = gg.Gross2 ?? 0;
            Gross[2] = gg.Gross3 ?? 0;
            Gross[3] = gg.Gross4 ?? 0;
            Gross[4] = gg.Gross5 ?? 0;
            Gross[5] = gg.Gross6 ?? 0;
            Gross[6] = gg.Gross7 ?? 0;
            Gross[7] = gg.Gross8 ?? 0;
            Gross[8] = gg.Gross9 ?? 0;
            Gross[9] = gg.Gross10 ?? 0;

            Income[0] = gg.Income1 ?? 0;
            Income[1] = gg.Income2 ?? 0;
            Income[2] = gg.Income3 ?? 0;
            Income[3] = gg.Income4 ?? 0;
            Income[4] = gg.Income5 ?? 0;
            Income[5] = gg.Income6 ?? 0;
            Income[6] = gg.Income7 ?? 0;
            Income[7] = gg.Income8 ?? 0;
            Income[8] = gg.Income9 ?? 0;
            Income[9] = gg.Income10 ?? 0;

            StringBuilder s = new StringBuilder(10000);
            s.Append(',', 8);
            s.Append("Economic Component");
            s.AppendLine();
            s.AppendLine();
            s.Append(',', 6);
            s.Append("output,employment,income,Grossstae");
            s.AppendLine();
            s.Append(',', 6);
            s.Append("mil s,thousend jobs,mil S,mil S");
            s.AppendLine();
            s.Append("Total Economy");
            
            s.AppendLine();
            s.Append("private");
            s.AppendLine();
           
            for (int i = 0; i < 10; i++)
            {
                s.Append(',');
                s.Append(i+1);
                s.Append(".");
                s.Append(lab[i]);
                s.Append(',', 5);
                s.Append(output[i]);
                s.Append(',');
                s.Append(Employment[i]);
                s.Append(',');
                s.Append(Income[i]);
                s.Append(',');
                s.Append(Gross[i]);
                s.AppendLine();

            }
           double  otot = 0;
           double etot = 0;
           double gtot = 0;
           double itot = 0;
            for (int i = 0; i < 10; i++)
            {
                otot = otot + output[i];
                etot = etot + Employment[i];
                gtot = gtot + Gross[i];
                itot = itot + Income[i];
            }

            s.Append("private sub total");
            s.Append(',', 6);
            s.Append(otot);
            s.Append(',');
                s.Append(etot);
                s.Append(',');
            s.Append(itot);
            s.Append(',');
            s.Append(gtot);
            s.AppendLine();
            s.Append("public");
            s.Append(',', 6);
            s.Append(gg.Output11 ?? 0);
            s.Append(',');
            s.Append(gg.Employment11 ?? 0);
            s.Append(',');
            s.Append(gg.Income11 ?? 0);
            s.Append(',');
            s.Append(gg.Gross11 ?? 0);
            s.AppendLine();
            s.Append("Total Effects(Private and public)");
            s.Append(',', 6);
            s.Append(otot+(gg.Output11 ?? 0));
            s.Append(',');
            s.Append(etot+gg.Employment11 ?? 0);
            s.Append(',');
            s.Append(itot+gg.Income11 ?? 0);
            s.Append(',');
            s.Append(gtot+gg.Gross11 ?? 0);
            s.AppendLine();
            //MemoryStream stream = CSVUtility.GetCSV(lab,output, Employment, Income, Gross);
            

            //var filename = "ExampleCSV.csv";
            //var contenttype = "text/csv";
            //Response.Clear();
            //Response.ContentType = contenttype;
            //Response.AddHeader("content-disposition", "attachment;filename=" + filename);
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);
            //Response.BinaryWrite(stream.ToArray());
            //Response.End();
            //return Json("", JsonRequestBehavior.AllowGet);
            string hh = s.ToString();
            return File(new System.Text.UTF8Encoding().GetBytes(hh), "text/CSV", "EconomicBase.CSV");
        }
       
        //public ActionResult report(String First, String last, String Main_cons_Rehabilitation, String Main_cons_New_Construction, String Main_cons_Joint_ventures, String Main_jobs_NoofContjobs, String HBR_ArchitectureandEngenering, String HBR_GeneralRequirements, String HBR_Sitework, String HBR_Concrete, String HBR_masonry, String HBR_Metals, String HBR_Woodandplasataic, String HBR_Thermalandmostureprotection, String HBR_DoorsandWindows, String HBR_Finishes, String HBR_Specialities, String HBR_Equipment, String HBR_Furnishings, String HBR_SpecialConstruction, String HBR_ConvertingSystems, String HBR_Mechanical, String HBR_Electrical, String HBR_Attorney_other, String HBR_LM__Sitework, String HBR_LM__Concrete, String HBR_LM__masonry, String HBR_LM__Metals, String HBR_LM__Woodandplasataic, String HBR_LM__Thermalandmostureprotection, String HBR_LM__DoorsandWindows, String HBR_LM__Finishes, String HBR_LM__Specialities, String HBR_LM__Equipment, String HBR_LM__Furnishings, String HBR_LM__SpecialConstruction, String HBR_LM__ConvertingSystems, String HBR_LM__Mechanical, String HBR_LM__Electrical)
        //{
        public ActionResult getreport(UIdata udata)
        {

            //set basic details from session
            udata.country = Session["country"].ToString(); ;
            udata.region = Convert.ToInt32( Session["region"].ToString());
            udata.report = Convert.ToInt32(Session["report"].ToString());
            //end

            //Global Variables
            //double	_nVectorSettings[ALLOCATED];	//Settings  are 175
            //int     _intMode;      // 1 - singleregion,  2 - multiregion
            //double	_ID;		//ID of current record, -1 if it hasn't been saved yet.
            //int     _iRestNation; // used to create a title for a report
            //CString	_zTitle;	//Title
            //CString _strRegion; // Currently selected region
            //_nVectorSettings[ISMS]=1 when IDC_BUTTON_MAINSTREET
            //_nVectorSettings[ISM]=1 when  IDC_BUTTON_MUSEUMS
            //_nVectorSettings[IST]=1 when IDC_BUTTON_TOURISM
            //_nVectorSettings[ISRH] =1 when IDC_BUTTON_REHAB
            //printReport when   _nVectorSettings[ALLOCATED-1]=2 then need to print multi region calcu
            //first printreport by doing before that cahnge _iRestNation=1 then call print report after that again we should change _nVectorSettings[ALLOCATED-1] = 1
            //after that we should again call print repot second time but before that change  _iRestNation = 0;
            //if single region selected (you can check like _nVectorSettings[ALLOCATED-1] = 1) in that case change _iRestNation = 0 and call print report

            const int MAINSTREET = 1;
            const int TOURISM = 5;
            const int MUSEUM = 16;
            const int GENERAL = 19;
            const int REHABONE = 23;
            const int REHABTWO = 27;
            const int REHABTHREE = 31;
            const int ISMS = 19;//  GENERAL;
            const int ISM = 20;//  GENERAL + 1
            const int IST = 21;//  GENERAL + 2
            const int ISRH = 22;//  GENERAL + 3

            const int ELEMINR3 = 34;

            const int SECTORS = 519;
            const int NumberOfMultipleRegions = 2;

            const int SICSECTORS = 1001;
            int iTypeOfRehab = 0;
            Dialogproc d = new Dialogproc();
            //assign region
           // d.region_name = udata.country;

            d.region_name = "Alabama";
            //selected main screens


            double assign = 0;
            if (udata.tab1 == true)
                assign = 1;
            else
                assign = 0;
            d._nVectorSettings[ISMS] = 1;//udata.tab1;
            //Report selection

            ///////////////// //main street values 
            {
                d._nVectorSettings[0] = 0;
                //aboc=ve  zero position 0-mainstrrt 1-musuem 2-tourism 3-rehab 4-all the above
                d._nVectorSettings[174] = 1; //single region  //////////////////needs to set from dropdown
                d._nVectorSettings[174] = 2;//testing multi region now

                d._nVectorSettings[MAINSTREET] = udata.MainJNCB;//m_nJobsFTE
                d._nVectorSettings[MAINSTREET + 1] = udata.CJV; //m_nJoint
                d._nVectorSettings[MAINSTREET + 2] = udata.MainCNC; //m_nNewConst
                d._nVectorSettings[MAINSTREET + 3] = udata.MainCR; //m_nRehab
                {
                    d._nVectorSettings[19] = 1;
                    d._nVectorSettings[20] = 1;
                    d._nVectorSettings[21] = 1;
                    d._nVectorSettings[22] = 1;
                }

            }
            ///////////////////when musumem selected
            {
                d._nVectorSettings[0] = 1;
                //aboc=ve  zero position 0-mainstrrt 1-musuem 2-tourism 3-rehab 4-all the above
                d._nVectorSettings[174] = 1; //single region  //////////////////needs to set from dropdown
                d._nVectorSettings[174] = 2;//testing multi region now

                //common 
                //4th screen values 
                d._nVectorSettings[MUSEUM] = udata.HMS;// CWizDialog5.m_nAnual;
                d._nVectorSettings[MUSEUM + 1] = udata.vc; // CWizDialog5.m_nContrib;
                d._nVectorSettings[MUSEUM + 2] = udata.tcs;  // CWizDialog5.m_nCap;
                d._nVectorSettings[19] = 1;
                d._nVectorSettings[20] = 1;
                d._nVectorSettings[21] = 1;
                d._nVectorSettings[22] = 1;



            }
            ///////////////////when Tourism selected  
            {
                d._nVectorSettings[0] = 1;
                //aboc=ve  zero position 0-mainstrrt 1-musuem 2-tourism 3-rehab 4-all the above
                d._nVectorSettings[174] = 1; //single region  //////////////////needs to set from dropdown
                d._nVectorSettings[174] = 2;//testing multi region now


                if (udata.three1 == true)
                    assign = 1;
                else
                    assign = 0;
                d._nVectorSettings[TOURISM] = assign;// udata.three1;
                if (udata.three4 == true)
                    assign = 1;
                else
                    assign = 0;
                d._nVectorSettings[TOURISM + 1] = assign;// udata.three4;

                d._nVectorSettings[TOURISM + 2] = udata.three6;
                d._nVectorSettings[TOURISM + 3] = udata.three5;
                d._nVectorSettings[TOURISM + 4] = udata.three8;
                d._nVectorSettings[TOURISM + 5] = udata.three7;

                d._nVectorSettings[TOURISM + 6] = udata.three10;
                d._nVectorSettings[TOURISM + 7] = udata.three9;
                d._nVectorSettings[TOURISM + 8] = udata.three2;
                d._nVectorSettings[TOURISM + 9] = udata.three3;
                d._nVectorSettings[TOURISM + 10] = 0;// ui need to be added three11
                d._nVectorSettings[19] = 1;
                d._nVectorSettings[20] = 1;
                d._nVectorSettings[21] = 1;
                d._nVectorSettings[22] = 1;

            }

            //Values of historic budling 1st screen  radio buttons read as integers in c++ then used below method
            //  GetIntFromBit(CWizDialog7.m_iSystem,CWizDialog7.m_iInterior, CWizDialog7.m_iSite, CWizDialog7.m_iMaterial,  CWizDialog7.m_iExterior, CWizDialog7.m_iSoftCost);
            //saved result to _nVectorSettings[REHABTWO + iTypeOfRehab]   iTypeOfRehab is 0-3 subscreens
            //_nVectorSettings[REHABTWO + iTypeOfRehab]=m_iSystem*32+m_iInterior*16+m_iSite*8+m_iMaterial*4+m_iExterior*2+m_iSoftCost
            //m_iSystem,m_iInterior..might be 1 or 0 as they are radiobuttons-so cool
            ///see below for the stuff

            //m_bDay = (int)_nVectorSettings[TOURISM];
            //m_bNight = (int)_nVectorSettings[TOURISM + 1];
            //m_dCD = _nVectorSettings[TOURISM + 2];
            //m_dCP = _nVectorSettings[TOURISM + 3];
            //m_dCLD = _nVectorSettings[TOURISM + 4];
            //m_dCLP = _nVectorSettings[TOURISM + 5];
            //m_dFD = _nVectorSettings[TOURISM + 6];
            //m_dFP = _nVectorSettings[TOURISM + 7];
            //m_dPD = _nVectorSettings[TOURISM + 8];
            //m_dDPPD = _nVectorSettings[TOURISM + 9];
            //m_dPN = _nVectorSettings[TOURISM + 10];
            //REHABILITATION WITH 3 SUB SCREENS so total screens rehab main screen+3sub screens =4  thast why nDialog   has SWITTCH cases 1 to4
            //each case has buttons 
            double sum = 0;
            //Mian screen thatis first screen which hs 4 options selections

            if (udata.rmaina == true)
                assign = 1;
            else
                assign = 0;
            d._nVectorSettings[REHABONE] = assign;  // udata.rmaina;// 1; //when   sigle family selected

            if (udata.rmainb == true)
                assign = 1;
            else
                assign = 0;
            d._nVectorSettings[REHABONE + 1] = assign;  // udata.rmainb;// 1; //  multi

            if (udata.rmainc == true)
                assign = 1;
            else
                assign = 0;
            d._nVectorSettings[REHABONE + 2] = assign;  // udata.rmainc; //commercial

            if (udata.rmaind == true)
                assign = 1;
            else
                assign = 0;
            d._nVectorSettings[REHABONE + 3] = assign;  // udata.rmaind; //civi
            //second screen-1'   single family =0;  second screen  iTypeOfRehab=0
            iTypeOfRehab = 0;
            sum = udata.r1a + (udata.r2a) * 2 + (udata.r3a) * 4 + (udata.r4a) * 8 + (udata.r5a) * 16 + (udata.r6a) * 32;

            d._nVectorSettings[REHABTWO + iTypeOfRehab] = sum;

            //get sum =m_iSystem+m_iInterior*2+m_iSite*4+m_iMaterial*8+m_iExterior*16+m_iSoftCost*32
            //second screen-2'   multiple family =1;  second screen  iTypeOfRehab=1
            iTypeOfRehab = 1;
            sum = udata.r1b + (udata.r2b) * 2 + (udata.r3b) * 4 + (udata.r4b) * 8 + (udata.r5b) * 16 + (udata.r6b) * 32;

            d._nVectorSettings[REHABTWO + iTypeOfRehab] = sum;

            //get sum =m_iSystem+m_iInterior*2+m_iSite*4+m_iMaterial*8+m_iExterior*16+m_iSoftCost*32

            //second screen-3    commerical =2;  second screen  iTypeOfRehab=2
            iTypeOfRehab = 2;
            sum = udata.r1c + (udata.r2c) * 2 + (udata.r3c) * 4 + (udata.r4c) * 8 + (udata.r5c) * 16 + (udata.r6c) * 32;

            d._nVectorSettings[REHABTWO + iTypeOfRehab] = sum;

            //get sum =m_iSystem+m_iInterior*2+m_iSite*4+m_iMaterial*8+m_iExterior*16+m_iSoftCost*32
            //second screnn-4'    civic =3;  second screen  iTypeOfRehab=3
            iTypeOfRehab = 3;
            sum = udata.r1d + (udata.r2d) * 2 + (udata.r3d) * 4 + (udata.r4d) * 8 + (udata.r5d) * 16 + (udata.r6d) * 32;


            d._nVectorSettings[REHABTWO + iTypeOfRehab] = sum;

            //get sum =m_iSystem+m_iInterior*2+m_iSite*4+m_iMaterial*8+m_iExterior*16+m_iSoftCost*32


            //third screen  single family =0;  second screen  iTypeOfRehab=0
            //REHABTHREE=31  iTypeOfRehab=0  ELEMINR3=34
            iTypeOfRehab = 0;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3)] = udata.r7a; // CWizDialog8.m_eudata.r
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 1] = udata.r8a; // CWizDialog8.m_e1;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 2] = udata.r9a;// CWizDialog8.m_e2;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 3] = udata.r10a; // CWizDialog8.m_e3;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 4] = udata.r11a; // CWizDialog8.m_e4;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 5] = udata.r12a; // CWizDialog8.m_e5;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 6] = udata.r13a;// CWizDialog8.m_e6;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 7] = udata.r14a; // CWizDialog8.m_e7;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 8] = udata.r15a; // CWizDialog8.m_e8;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 9] = udata.r16a; // CWizDialog8.m_e9;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 10] = udata.r17a; // CWizDialog8.m_e1udata.r
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 11] = udata.r18a; // CWizDialog8.m_e11;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 12] = udata.r19a; // CWizDialog8.m_e12;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 13] = udata.r20a; // CWizDialog8.m_e13;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 14] = udata.r21a; // CWizDialog8.m_e14;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 15] = udata.r22a; // CWizDialog8.m_e15;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 16] = udata.r23a; // CWizDialog8.m_e16;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 17] = udata.r24a; // CWizDialog8.m_e17;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 18] = udata.r25a; // CWizDialog8.m_eTotal;

            //  third screen  multiple family =0; //1;  second screen  iTypeOfRehab=0; 
            iTypeOfRehab = 1;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3)] = udata.r7b; // CWizDialog8.m_eudata.r
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 1] = udata.r8b; // CWizDialog8.m_e1;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 2] = udata.r9b; // CWizDialog8.m_e2;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 3] = udata.r10b; // CWizDialog8.m_e3;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 4] = udata.r11b; // CWizDialog8.m_e4;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 5] = udata.r12b; // CWizDialog8.m_e5;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 6] = udata.r13b; // CWizDialog8.m_e6;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 7] = udata.r14b; // CWizDialog8.m_e7;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 8] = udata.r15b; // CWizDialog8.m_e8;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 9] = udata.r16b; // CWizDialog8.m_e9;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 10] = udata.r17b; // CWizDialog8.m_e1udata.r
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 11] = udata.r18b; // CWizDialog8.m_e11;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 12] = udata.r19b; // CWizDialog8.m_e12;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 13] = udata.r20b; // CWizDialog8.m_e13;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 14] = udata.r21b; // CWizDialog8.m_e14;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 15] = udata.r22b; // CWizDialog8.m_e15;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 16] = udata.r23b; // CWizDialog8.m_e16;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 17] = udata.r24b; // CWizDialog8.m_e17;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 18] = udata.r25b; // CWizDialog8.m_eTotal;
            //  third screen multiple commerical =2;  second screen  iTypeOfRehab=2
            iTypeOfRehab = 2;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3)] = udata.r7c; // CWizDialog8.m_eudata.r
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 1] = udata.r8c; // CWizDialog8.m_e1;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 2] = udata.r9c; // CWizDialog8.m_e2;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 3] = udata.r10c; // CWizDialog8.m_e3;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 4] = udata.r11c; // CWizDialog8.m_e4;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 5] = udata.r12c; // CWizDialog8.m_e5;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 6] = udata.r13c; // CWizDialog8.m_e6;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 7] = udata.r14c; // CWizDialog8.m_e7;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 8] = udata.r15c; // CWizDialog8.m_e8;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 9] = udata.r16c; // CWizDialog8.m_e9;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 10] = udata.r17c; // CWizDialog8.m_e1udata.r
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 11] = udata.r18c; // CWizDialog8.m_e11;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 12] = udata.r19c; // CWizDialog8.m_e12;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 13] = udata.r20c; // CWizDialog8.m_e13;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 14] = udata.r21c; // CWizDialog8.m_e14;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 15] = udata.r22c; // CWizDialog8.m_e15;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 16] = udata.r23c; // CWizDialog8.m_e16;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 17] = udata.r24c; // CWizDialog8.m_e17;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 18] = udata.r25c; // CWizDialog8.m_eTotal;
            //  third screen  civic =3;  second screen  iTypeOfRehab=3
            iTypeOfRehab = 3;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3)] = udata.r7d; // CWizDialog8.m_eudata.r
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 1] = udata.r8d; // CWizDialog8.m_e1;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 2] = udata.r9d; // CWizDialog8.m_e2;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 3] = udata.r10d; // CWizDialog8.m_e3;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 4] = udata.r11d; // CWizDialog8.m_e4;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 5] = udata.r12d; // CWizDialog8.m_e5;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 6] = udata.r13d; // CWizDialog8.m_e6;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 7] = udata.r14d; // CWizDialog8.m_e7;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 8] = udata.r15d; // CWizDialog8.m_e8;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 9] = udata.r16d; // CWizDialog8.m_e9;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 10] = udata.r17d; // CWizDialog8.m_e1udata.r
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 11] = udata.r18d; // CWizDialog8.m_e11;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 12] = udata.r19d; // CWizDialog8.m_e12;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 13] = udata.r20d; // CWizDialog8.m_e13;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 14] = udata.r21d; // CWizDialog8.m_e14;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 15] = udata.r22d; // CWizDialog8.m_e15;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 16] = udata.r23d; // CWizDialog8.m_e16;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 17] = udata.r24d; // CWizDialog8.m_e17;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 18] = udata.r25d; // CWizDialog8.m_eTotal;
            //four screen  single family =0;  second screen  iTypeOfRehab=0
            iTypeOfRehab = 0;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 19] = udata.r26a; // CWizDialog10.m_d2;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 20] = udata.r27a; // CWizDialog10.m_d3;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 21] = udata.r28a; // CWizDialog10.m_d4;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 22] = udata.r29a; // CWizDialog10.m_d5;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 23] = udata.r30a; // CWizDialog10.m_d6;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 24] = udata.r31a; // CWizDialog10.m_d7;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 25] = udata.r32a; // CWizDialog10.m_d8;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 26] = udata.r33a; // CWizDialog10.m_d9;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 27] = udata.r34a; // CWizDialog10.m_d1udata.r
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 28] = udata.r35a; // CWizDialog10.m_d11;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 29] = udata.r36a; // CWizDialog10.m_d12;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 30] = udata.r37a; // CWizDialog10.m_d13;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 31] = udata.r38a; // CWizDialog10.m_d14;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 32] = udata.r39a; // CWizDialog10.m_d15;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 33] = udata.r40a; // CWizDialog10.m_d16;
            //  four screen  multiple family =1;  second screen  iTypeOfRehab=1
            iTypeOfRehab = 1;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 19] = udata.r26b; // CWizDialog10.m_d2;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 20] = udata.r27b; // CWizDialog10.m_d3;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 21] = udata.r28b; // CWizDialog10.m_d4;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 22] = udata.r29b; // CWizDialog10.m_d5;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 23] = udata.r30b; // CWizDialog10.m_d6;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 24] = udata.r31b; // CWizDialog10.m_d7;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 25] = udata.r32b; // CWizDialog10.m_d8;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 26] = udata.r33b; // CWizDialog10.m_d9;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 27] = udata.r34b; // CWizDialog10.m_d1udata.r
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 28] = udata.r35b; // CWizDialog10.m_d11;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 29] = udata.r36b; // CWizDialog10.m_d12;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 30] = udata.r37b; // CWizDialog10.m_d13;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 31] = udata.r38b; // CWizDialog10.m_d14;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 32] = udata.r39b; // CWizDialog10.m_d15;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 33] = udata.r40b; // CWizDialog10.m_d16;
            //  four screen multiple commerical =2;  second screen  iTypeOfRehab=2
            iTypeOfRehab = 2;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 19] = udata.r26c; // CWizDialog10.m_d2;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 20] = udata.r27c; // CWizDialog10.m_d3;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 21] = udata.r28c; // CWizDialog10.m_d4;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 22] = udata.r29c; // CWizDialog10.m_d5;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 23] = udata.r30c; // CWizDialog10.m_d6;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 24] = udata.r31c; // CWizDialog10.m_d7;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 25] = udata.r32c; // CWizDialog10.m_d8;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 26] = udata.r33c; // CWizDialog10.m_d9;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 27] = udata.r34c; // CWizDialog10.m_d1udata.r
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 28] = udata.r35c; // CWizDialog10.m_d11;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 29] = udata.r36c; // CWizDialog10.m_d12;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 30] = udata.r37c; // CWizDialog10.m_d13;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 31] = udata.r38c; // CWizDialog10.m_d14;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 32] = udata.r39c; // CWizDialog10.m_d15;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 33] = udata.r40c; // CWizDialog10.m_d16;
            //  four screen  civic =3;  second screen  iTypeOfRehab=3
            iTypeOfRehab = 3;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 19] = udata.r26d; // CWizDialog10.m_d2;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 20] = udata.r27d; // CWizDialog10.m_d3;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 21] = udata.r28d; // CWizDialog10.m_d4;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 22] = udata.r29d; // CWizDialog10.m_d5;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 23] = udata.r30d; // CWizDialog10.m_d6;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 24] = udata.r31d; // CWizDialog10.m_d7;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 25] = udata.r32d; // CWizDialog10.m_d8;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 26] = udata.r33d; // CWizDialog10.m_d9;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 27] = udata.r34d; // CWizDialog10.m_d1udata.r
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 28] = udata.r35d; // CWizDialog10.m_d11;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 29] = udata.r36d; // CWizDialog10.m_d12;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 30] = udata.r37d; // CWizDialog10.m_d13;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 31] = udata.r38d; // CWizDialog10.m_d14;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 32] = udata.r39d; // CWizDialog10.m_d15;
            d._nVectorSettings[REHABTHREE + (iTypeOfRehab * ELEMINR3) + 33] = udata.r40d; // CWizDialog10.m_d16;

            d._nVectorSettings[13] = 100;
            d._nVectorSettings[15] = 100;
            d._nVectorSettings[174] = 1;
            d._nVectorSettings[0] = 2;
            //testing
            {
                d._nVectorSettings[0] = 3;
                d._nVectorSettings[19] = 1;
                d._nVectorSettings[20] = 1;
                d._nVectorSettings[21] = 1;
                d._nVectorSettings[22] = 1;
                d._nVectorSettings[23] = 1;
                d._nVectorSettings[24] = 1;
                d._nVectorSettings[25] = 1;
                d._nVectorSettings[26] = 1;
                d._nVectorSettings[151] = 1000;
                d._nVectorSettings[117] = 1000;
                d._nVectorSettings[83] = 1000;
                d._nVectorSettings[49] = 1000;
                d._nVectorSettings[174] = 1;
                d._nVectorSettings[31] = 10.434782608999999;
                d._nVectorSettings[32] = 8.5180315145330638;
                d._nVectorSettings[33] = 10.873933294822043;
                d._nVectorSettings[34] = 2.0344472079604237;
                d._nVectorSettings[35] = 8.6823881436173220;
                d._nVectorSettings[36] = 0.55312051296503995;
                d._nVectorSettings[37] = 15.810504745755818;
                d._nVectorSettings[38] = 4.3649790078620603;
                d._nVectorSettings[39] = 10.702220029152750;
                d._nVectorSettings[40] = 14.564189834970676;
                d._nVectorSettings[41] = 0.21284007698340401;
                d._nVectorSettings[42] = 2.2583748696939856;
                d._nVectorSettings[46] = 6.0628293558980122;
                d._nVectorSettings[47] = 2.3186631449158424;
                d._nVectorSettings[48] = 2.6086956521739131;
                d._nVectorSettings[49] = 1000.0000000000000;
                d._nVectorSettings[50] = 60.000000000000000;
                d._nVectorSettings[51] = 60.000000000000000;
                d._nVectorSettings[52] = 60.000000000000000;
                d._nVectorSettings[53] = 40.000000000000000;
                d._nVectorSettings[54] = 35.000000000000000;
                d._nVectorSettings[55] = 45.000000000000000;
                d._nVectorSettings[56] = 35.000000000000000;
                d._nVectorSettings[57] = 35.000000000000000;
                d._nVectorSettings[58] = 30.000000000000000;
                d._nVectorSettings[59] = 15.000000000000000;
                d._nVectorSettings[60] = 15.000000000000000;
                d._nVectorSettings[61] = 15.000000000000000;
                d._nVectorSettings[62] = 15.000000000000000;
                d._nVectorSettings[63] = 60.000000000000000;
                d._nVectorSettings[64] = 60.000000000000000;
                d._nVectorSettings[65] = 10.200624791999999;
                d._nVectorSettings[66] = 8.3268858300116086;
                d._nVectorSettings[67] = 12.873933294822043;
                d._nVectorSettings[68] = 1.9887939600797508;
                d._nVectorSettings[69] = 8.4875542759377787;
                d._nVectorSettings[70] = 0.54070841999576935;
                d._nVectorSettings[71] = 15.455715056717800;
                d._nVectorSettings[72] = 4.2670283371048496;
                d._nVectorSettings[73] = 10.462060883241939;
                d._nVectorSettings[74] = 14.237367607234589;
                d._nVectorSettings[75] = 0.20806391923625556;
                d._nVectorSettings[76] = 2.2076966572880794;
                d._nVectorSettings[80] = 5.9267787125782894;
                d._nVectorSettings[81] = 2.2666320561304301;
                d._nVectorSettings[82] = 2.5501561979241645;
                d._nVectorSettings[83] = 1000.0000000000000;
                d._nVectorSettings[84] = 60.000000000000000;
                d._nVectorSettings[85] = 60.000000000000000;
                d._nVectorSettings[86] = 60.000000000000000;
                d._nVectorSettings[87] = 40.000000000000000;
                d._nVectorSettings[88] = 35.000000000000000;
                d._nVectorSettings[89] = 45.000000000000000;
                d._nVectorSettings[90] = 35.000000000000000;
                d._nVectorSettings[91] = 35.000000000000000;
                d._nVectorSettings[92] = 30.000000000000000;
                d._nVectorSettings[93] = 15.000000000000000;
                d._nVectorSettings[94] = 15.000000000000000;
                d._nVectorSettings[95] = 15.000000000000000;
                d._nVectorSettings[96] = 15.000000000000000;
                d._nVectorSettings[97] = 60.000000000000000;
                d._nVectorSettings[98] = 60.000000000000000;
                d._nVectorSettings[99] = 10.434782608999999;
                d._nVectorSettings[100] = 8.5180315145330638;
                d._nVectorSettings[101] = 10.873933294822043;
                d._nVectorSettings[102] = 2.0344472079604237;
                d._nVectorSettings[103] = 5.5130059195548720;
                d._nVectorSettings[104] = 0.55312051296503995;
                d._nVectorSettings[105] = 18.979886969818267;
                d._nVectorSettings[106] = 4.3649790078620603;
                d._nVectorSettings[107] = 10.702220029152750;
                d._nVectorSettings[108] = 14.564189834970676;
                d._nVectorSettings[109] = 0.21284007698340401;
                d._nVectorSettings[110] = 2.2583748696939856;
                d._nVectorSettings[111] = 0.00000000000000000;
                d._nVectorSettings[112] = 0.00000000000000000;
                d._nVectorSettings[113] = 0.00000000000000000;
                d._nVectorSettings[114] = 6.0628293558980122;
                d._nVectorSettings[115] = 2.3186631449158424;
                d._nVectorSettings[116] = 2.6086956521739131;
                d._nVectorSettings[117] = 1000.0000000000000;
                d._nVectorSettings[118] = 60.000000000000000;
                d._nVectorSettings[119] = 60.000000000000000;
                d._nVectorSettings[120] = 60.000000000000000;
                d._nVectorSettings[121] = 40.000000000000000;
                d._nVectorSettings[122] = 35.000000000000000;

                d._nVectorSettings[123] = 45.000000000000000;
                d._nVectorSettings[124] = 35.000000000000000;
                d._nVectorSettings[125] = 35.000000000000000;
                d._nVectorSettings[126] = 30.000000000000000;
                d._nVectorSettings[127] = 15.000000000000000;

                d._nVectorSettings[128] = 15.000000000000000;
                d._nVectorSettings[129] = 15.000000000000000;
                d._nVectorSettings[130] = 15.000000000000000;
                d._nVectorSettings[131] = 60.000000000000000;
                d._nVectorSettings[132] = 60.000000000000000;
                d._nVectorSettings[133] = 10.200624791999999;
                d._nVectorSettings[134] = 8.3268858300116086;
                d._nVectorSettings[135] = 12.873933294822043;
                d._nVectorSettings[136] = 1.9887939600797508;
                d._nVectorSettings[137] = 5.3892933823957607;
                d._nVectorSettings[138] = 0.54070841999576935;
                d._nVectorSettings[139] = 18.553975950259819;
                d._nVectorSettings[140] = 4.2670283371048496;
                d._nVectorSettings[141] = 10.462060883241939;
                d._nVectorSettings[142] = 14.237367607234589;
                d._nVectorSettings[143] = 0.20806391923625556;
                d._nVectorSettings[144] = 2.2076966572880794;
                d._nVectorSettings[148] = 5.9267787125782894;
                d._nVectorSettings[149] = 2.2666320561304301;
                d._nVectorSettings[150] = 2.5501561979241645;
                d._nVectorSettings[151] = 1000.0000000000000;
                d._nVectorSettings[152] = 60.000000000000000;
                d._nVectorSettings[153] = 60.000000000000000;
                d._nVectorSettings[154] = 60.000000000000000;
                d._nVectorSettings[155] = 40.000000000000000;

                d._nVectorSettings[156] = 35.000000000000000;
                d._nVectorSettings[157] = 45.000000000000000;

                d._nVectorSettings[158] = 35.000000000000000;
                d._nVectorSettings[159] = 35.000000000000000;
                d._nVectorSettings[160] = 30.000000000000000;
                d._nVectorSettings[161] = 15.000000000000000;
                d._nVectorSettings[162] = 15.000000000000000;
                d._nVectorSettings[163] = 15.000000000000000;
                d._nVectorSettings[164] = 15.000000000000000;
                d._nVectorSettings[165] = 60.000000000000000;
                d._nVectorSettings[166] = 60.000000000000000;
            }
            //testing
            if (d._nVectorSettings[174] == 1)
                d.CalculationsThread();
            else d.MultiregionCalculationsThread();
            //above tested working
            //
            Session["economy"] = d.tblEconomicBase;


            //return View(xx);
            return Json(d.dblCalcVector, JsonRequestBehavior.AllowGet);
        }

        public ActionResult showlistofmylogs(string user)
        {
            //reading name from  session or viewbag after login
            var v=repository.getuserhistory(user);
           List<historymodelview> userhistory=v;
           return View(userhistory);
        }
    }
   
}

