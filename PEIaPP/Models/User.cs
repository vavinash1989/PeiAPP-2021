using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PEIaPP.Models
{
    public class User
    {
        public string username { set; get; }
        public String password { set; get; }
    }
}
namespace PEIaPP
{
    using System;
    using System.Collections.Generic;

    public partial class tblTemp
    {

        public tblTemp(int ID, double Income, double Employment, double GDP, double Output)
        {
            this.ID = ID;
            this.Income = Income;
            this.Employment = Employment;
            this.GDP = GDP;
            this.Output = Output;
        }

        public tblTemp()
        {
            this.ID = 0;
            this.Income = 0;
            this.Employment = 0; ;
            this.GDP = 0;
            this.Output = 0;

        }
    }

    public partial class GeneralInfo
    {
        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }

    }

    public partial class tblGeneralIndustry
    {
        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }

    }
}


//commesnts

//     tblGeneralIndustry.Add(gi);





//Relacing the postion basedwith exact property names
//if (0 < 1)
//{
//    gi.Employment1 = dblGIndustry[0, 0];
//    gi.Employment2 = dblGIndustry[1, 0];
//    gi.Employment3 = dblGIndustry[2, 0];
//    gi.Employment4 = dblGIndustry[3, 0];
//    gi.Employment5 = dblGIndustry[4, 0];
//    gi.Employment6 = dblGIndustry[5, 0];
//    gi.Employment7 = dblGIndustry[6, 0];
//    gi.Employment8 = dblGIndustry[7, 0];
//    gi.Employment9 = dblGIndustry[8, 0];
//    gi.Employment10 = dblGIndustry[9, 0];
//    gi.Employment11 = dblGIndustry[10, 0];



//    gi.Income1 = dblGIndustry[14, 1];
//    gi.Income2 = dblGIndustry[15, 1];
//    gi.Income3 = dblGIndustry[16, 1];
//    gi.Income4 = dblGIndustry[17, 1];
//    gi.Income5 = dblGIndustry[18, 1];
//    gi.Income6 = dblGIndustry[19, 1];
//    gi.Income7 = dblGIndustry[20, 1];
//    gi.Income8 = dblGIndustry[21, 1];
//    gi.Income9 = dblGIndustry[22, 1];
//    gi.Income10 = dblGIndustry[23, 1];
//    gi.Income11 = dblGIndustry[24, 1];



//    gi.Gross1 = dblGIndustry[28, 2];
//    gi.Gross2 = dblGIndustry[29, 2];
//    gi.Gross3 = dblGIndustry[30, 2];
//    gi.Gross4 = dblGIndustry[31, 2];
//    gi.Gross5 = dblGIndustry[32, 2];
//    gi.Gross6 = dblGIndustry[33, 2];
//    gi.Gross7 = dblGIndustry[34, 2];
//    gi.Gross8 = dblGIndustry[35, 2];
//    gi.Gross9 = dblGIndustry[36, 2];
//    gi.Gross10 = dblGIndustry[37, 2];
//    gi.Gross11 = dblGIndustry[38, 2];














//    gi.Output1 = dblGIndustry[53, 3];
//    gi.Output2 = dblGIndustry[54, 3];
//    gi.Output3 = dblGIndustry[55, 3];
//    gi.Output4 = dblGIndustry[56, 3];
//    gi.Output5 = dblGIndustry[57, 3];
//    gi.Output6 = dblGIndustry[58, 3];
//    gi.Output7 = dblGIndustry[59, 3];
//    gi.Output8 = dblGIndustry[60, 3];
//    gi.Output9 = dblGIndustry[61, 3];
//    gi.Output10 = dblGIndustry[62, 3];
//    gi.Output11 = dblGIndustry[63, 3];


//    }
