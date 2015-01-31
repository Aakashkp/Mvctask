using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ViewDemoController : Controller
    {
        // GET: ViewDemo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Welcome(string name,int numtimes=4)
        {
            ViewBag.Message = "Hello"+name;
            ViewBag.NumTimes =numtimes;

            return View();
        }
    }
}