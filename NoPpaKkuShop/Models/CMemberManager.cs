using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoPpaKkuShop.Models
{
    public class CMemberManager
    {
        //private List<CMember> theMembers;

        LMemberDataContext theMemberContext;
        public CMemberManager()
        {
            //theMembers = new List<CMember>();
            theMemberContext = new LMemberDataContext();
        }

        public int AddMember(ref CMember member)
        {
            /* CMember tmpMember = new CMember();

             tmpMember.theUniqueID = 0;
             tmpMember.theID = member.theID;
             tmpMember.thePW = member.thePW;
             tmpMember.thePhone = member.thePhone;
             tmpMember.theEMail = member.theEMail;
             theMembers.Add(tmpMember);*/

            TUser tmpMember = new TUser();
            tmpMember.userID = member.theID;
            tmpMember.userPW = member.thePW;
            tmpMember.cellularPhone = member.thePhone;
            tmpMember.eMail = member.theEMail;

            theMemberContext.TUser.InsertOnSubmit(tmpMember);
            theMemberContext.SubmitChanges();

            

            return 1;         

            
        }

        public List<CMember> GetMembers()
        {

            //return theMembers;
            IQueryable<TUser> tmpR = theMemberContext.TUser.OrderByDescending(x => x.userID);

            List<TUser> tmpL = tmpR.ToList<TUser>();
            List<CMember> resMembers = new List<CMember>();
            foreach(TUser iter in tmpL)
            {
                CMember tmpMember = new CMember();
                tmpMember.theUniqueID = iter.uniqueID;
                tmpMember.thePW = iter.userPW;
                tmpMember.thePhone = iter.cellularPhone;
                tmpMember.theEMail = iter.eMail;

                resMembers.Add(tmpMember);
            }
            return resMembers;
        }

        public int CheckUser(string aID, string aPW)
        {
           /* foreach(CMember iter in theMembers)
            {
                if(iter.theID.Equals(aID) == true  && iter.thePW.Equals(aPW) == true)
                {
                    return 1;
                }
            }*/
            return 0;
        }
    }
}