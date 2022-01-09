using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVCRouting.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index(int year, int month, int day)
        {
            ViewBag.Year = year.ToString();
            ViewBag.Month = month.ToString();
            ViewBag.Day = day;
            return View();
        }
    }
}