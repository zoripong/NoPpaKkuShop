using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NoPpaKkuShop.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        // 가입관리
        public ActionResult Approval()
        {
            return View();
        }

        // 입금관리
        public ActionResult DepositManage()
        {
            return View();
        }

        // 상품관리
        public ActionResult ProdManage()
        {
            return View();
        }

        // 가입관리 & 탈퇴관리
        public ActionResult MemberManage()
        {
            return View();
        }

        // 탈퇴관리
        public ActionResult Secession()
        {
            return View();
        }
    }
}