using Stock.Web.Infrastructure;
using Stock.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Stock.Web.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        private IMembershipService _membershipService = new AccountMembershipService();

        public ActionResult Login()
        {
            if (Request.IsAuthenticated)
            {
                return RedirectToRoute("Dashboard");
            }
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model) {
            if (ModelState.IsValid)
            {
                if (_membershipService.ValidateUser(model.UserName, model.Password))
                {
                    SetupFormsAuthTicket(model.UserName, false);
                    return RedirectToRoute("Dashboard");
                }
                ModelState.AddModelError("", "Invalid username or password");
                return View(model);
            }
            return View(model);
        }
        public ActionResult Register() {
            if (Request.IsAuthenticated)
            {
                return RedirectToRoute("Dashboard");
            }
            RegisterViewModel model = new RegisterViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel register) {
            if (ModelState.IsValid)
            {
                var status = _membershipService.CreateUser(register.UserName, register.Password, register.Email);
                if (status.ToString() == "Success")
                {
                    return RedirectToAction("Login", "Account");
                }
                else if (status.ToString() == "DuplicateEmail") {
                    ModelState.AddModelError("", "Duplicate Email");
                }
                else if (status.ToString() == "DuplicateUserName") {
                    ModelState.AddModelError("", "Duplicate UserName");
                }
            }
            return View(register);
        }
        private void SetupFormsAuthTicket(string userName, bool persistanceFlag)
        {

            var userData = userName;
            var authTicket = new FormsAuthenticationTicket(1, //version
                                                        userName, // user name
                                                        DateTime.Now,             //creation
                                                        DateTime.Now.AddMinutes(30), //Expiration
                                                        persistanceFlag, //Persistent
                                                        userData);

            var encTicket = FormsAuthentication.Encrypt(authTicket);
            Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));

        }

        public ActionResult LogOut()
        {
            if (Request.IsAuthenticated)
            {
                FormsAuthentication.SignOut();
            }
            return RedirectToAction("Login", "Account");

        }
    }
}
