using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using MVCTutorial.Areas.Admin.Helpers;
using Repositories;
using Repositories.Interface;

namespace MVCTutorial.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {   
        [HttpGet]
        public ActionResult Index()
        {   
            return View();
        }

        [HttpPost]
        public ActionResult Index(Account form)
        {   
            IAccountRepository _accountRepository = new AccountRepository();
            var re = _accountRepository.Login(form.UserName, form.Password);
            if (re)
            {
                SessionHelper.SetSession(new UserSession(){ UserName = form.UserName });
                return RedirectToAction("Index","Home");
            }

            ViewBag.ErrorMessage = "Tên đăng nhập hoặc mật khẩu không đúng !";
            return View();
        }

    }
}