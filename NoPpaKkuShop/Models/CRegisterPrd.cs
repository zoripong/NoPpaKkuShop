using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// create by Yuri
namespace NoPpaKkuShop.Models
{
    public class CRegisterPrd
    {
        public int theUniqueID { get; set; }
        public String theProductName { get; set; }
        public int theUserUniqueID { get; set; }
        public int theAmount { get; set; }
        public int theOptionUniqueID { get; set; }
        public String theExplain { get; set; }
        public int theBeforeCharge { get; set; }
        public int theAfterCharge { get; set; }
        public DateTime theStartDate { get; set; }
        public DateTime theEndDate { get; set; }

        public String theFileName { get; set; }
        public String theHDDName { get; set; }
        public HttpPostedFileBase theFile { get; set; }

        public int getCharge()
        {
            return theBeforeCharge + theAfterCharge;
        }
    }
}