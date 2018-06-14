using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

using NoPpaKkuShop.Models;

namespace NoPpaKkuShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.theMembers = CInstance.theMemberManager.GetMembers();
           ViewBag.theLoginUser = 
            ViewBag.thePrds = CInstance.thePrdManager.GetRegisterPrds();
            return View();
        }
        
        // 상품등록 : 등록하는 페이지로 이동
        public ActionResult Register()
        {
            return View();
        }

        // 상품등록 : 실제 등록할 때
        [HttpPost]
        public ActionResult Register(CRegisterPrd aPrd)
        {

            HttpPostedFileBase file = aPrd.theFile;

            string ext = Path.GetExtension(file.FileName);
            string tmpFileName = Path.GetRandomFileName() + ext;
            string path = Path.Combine(Server.MapPath("~/Products"), tmpFileName);
            file.SaveAs(path);
            //			aFileName = Path.GetFileName( file.FileName );
            //			aHDDName = tmpFileName;

            aPrd.theFileName = file.FileName;
            aPrd.theHDDName = tmpFileName;

            int tmpBool;
            tmpBool = CInstance.thePrdManager.AddRegisterPrd(ref aPrd);
            if(tmpBool == 1)
            {
                return RedirectToAction("", aPrd);
            }
            return View( aPrd );
        }

        // 상세 페이지
        public ActionResult DetailView( string number )
        {
            return View();
        }

        // 결제창
        public ActionResult Payment()
        {
            return View();
        }

        // 사용자 계정
        public ActionResult UserAccount()
        {
            ViewBag.thePrds = CInstance.thePrdManager.GetRegisterPrds();
            return View();
        }

        // 로그인
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(CLoginUser loginuser)
        {
            Console.WriteLine(loginuser.theID);
            Console.WriteLine(loginuser.thePW);
            return RedirectToAction("Index", loginuser);
        }

        // 회원가입
        public ActionResult SignIn()
        {
            ViewBag.bFail = 0;
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(CMember member)
        {
            int tmpBool;
            tmpBool = CInstance.theMemberManager.AddMember(ref member);
            if(tmpBool == 1)
            {
                return RedirectToAction("Index", member);
            }
            return View(member);
        }

        // 계정찾기
        public ActionResult SearchAccount()
        {
            return View();
        }

        public ActionResult PurchasePrd()
        {
            return View()
        }

    }

}