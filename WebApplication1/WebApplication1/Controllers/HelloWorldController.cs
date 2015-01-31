using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "Ihis is my<b>default</b> action....";
        }
        public string Welcome()
        {
            return "This is the Welcome action method....";
        }
       public string WelcomeParam(string Name,int numTimes=1)
        {
            return HttpUtility.HtmlEncode("Hello" + Name + ",NumTimes is:" + numTimes);
        }
        public string WithoutParameter(string name,int id=1)
       {
           return HttpUtility.HtmlEncode("Hello" + name + ",Id:" + id);
       }
    }
}