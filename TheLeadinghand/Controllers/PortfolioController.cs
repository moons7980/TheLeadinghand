using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheLeadinghand.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult KDMotorworx()
        {
            return View();
        }
        public ActionResult NoCourt()
        {
            return View();
        }
        public ActionResult ImportanceOfCommunication()
        {
            return View();
        }
    }
}