using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoPpaKkuShop.Models
{
    public class CInstance
    {
        public static CMemberManager theMemberManager;
        public static CPrdManager thePrdManager;
        public static int bInit = 0;

        public static void Initialize()
        {
            if (bInit == 0)
            {
                theMemberManager = new CMemberManager();
                thePrdManager = new CPrdManager();
            }
            bInit = 1;
        }
    }
}