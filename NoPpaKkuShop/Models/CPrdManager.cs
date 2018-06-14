using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// create by Yuri
namespace NoPpaKkuShop.Models
{
    public class CPrdManager
    {

        LRegisterPrdDataContext theRegisterPrdContext;

        public CPrdManager()
        {
            theRegisterPrdContext = new LRegisterPrdDataContext();
        }

        public int AddRegisterPrd(ref CRegisterPrd aPrd)
        {
            TRegisterPrd tmpPrd = new TRegisterPrd();
            tmpPrd.uniqueID = aPrd.theUniqueID;
            tmpPrd.productName = aPrd.theProductName;
            tmpPrd.userUniqueID = aPrd.theUserUniqueID;
            tmpPrd.amount = aPrd.theAmount;
            tmpPrd.optionUniqueID = aPrd.theOptionUniqueID;
            tmpPrd.explain = aPrd.theExplain;
            tmpPrd.beforeCharge = aPrd.theBeforeCharge;
            tmpPrd.afterCharge = aPrd.theAfterCharge;
            tmpPrd.startDate = aPrd.theStartDate;
            tmpPrd.endDate = aPrd.theEndDate;
            tmpPrd.hddName = aPrd.theHDDName;
            tmpPrd.fileName = aPrd.theFileName;

            theRegisterPrdContext.TRegisterPrd.InsertOnSubmit(tmpPrd);
            theRegisterPrdContext.SubmitChanges();

            return 1;

        }

        public List<CRegisterPrd> GetRegisterPrds()
        {
            IQueryable<TRegisterPrd> tmpR = theRegisterPrdContext.TRegisterPrd.OrderByDescending(x => x.uniqueID);
            List<CRegisterPrd> resPrds = new List<CRegisterPrd>();

            foreach(TRegisterPrd iter in tmpR)
            {
                CRegisterPrd tmpPrd = new CRegisterPrd();
                
                tmpPrd.theUniqueID = iter.uniqueID;
                tmpPrd.theProductName = iter.productName;
                tmpPrd.theUserUniqueID = iter.userUniqueID;
                tmpPrd.theAmount = iter.amount;
                tmpPrd.theOptionUniqueID = iter.optionUniqueID;
                tmpPrd.theExplain = iter.explain;
                tmpPrd.theBeforeCharge = iter.beforeCharge;
                tmpPrd.theAfterCharge = iter.afterCharge;
                tmpPrd.theStartDate = iter.startDate;
                tmpPrd.theEndDate = iter.endDate;
                tmpPrd.theFileName = iter.fileName;
                tmpPrd.theHDDName = iter.hddName;

                resPrds.Add(tmpPrd);
            }

            return resPrds;
        }


    }
}