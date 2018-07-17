using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPlatform.Controllers
{
    public class StartPageController : Controller
    {
        // GET: StartPage
        public ActionResult Index()
        {
            return View();
        }

        public void Register()
        {
            var emailReg = Request["emailRegister"];
            var passwordReg = Request["passwordRegister"];
            var firstNameReg = Request["firstnameRegister"];
            var lastnameReg = Request["lastnameRegister"];
            var phoneReg = Request["phoneRegister"];

            Debug.Write(emailReg + " -- " + passwordReg + " -- " + firstNameReg + " -- " + lastnameReg + " -- " + phoneReg);
        }
    }
}