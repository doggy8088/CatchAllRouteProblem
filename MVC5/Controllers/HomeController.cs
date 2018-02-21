using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string path)
        {
            var url = Url.Action("Index", new { path = "hello/world" });
            return Content("Path = [" + path + "], built URL = " + url);
        }
    }
}