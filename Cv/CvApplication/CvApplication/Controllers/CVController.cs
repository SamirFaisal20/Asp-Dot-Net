using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CvApplication.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        public ActionResult Name()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Skl()
        {
            return View();
        }
    }
}