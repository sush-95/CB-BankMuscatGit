using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankDashboard.Controllers
{
    public class CBController : Controller
    {
        // GET: CB
        public ActionResult Index()
        {
            ViewBag.botstat = "active";
            return View();
        }
        public ActionResult WC()
        {
            ViewBag.wcstat = "active";
            try
            {

            }
            catch(Exception ex)
            {
                TempData["Error"] = "Somthing went wrong.."+ex.Message;
            }
            return View();
        }
    }
}