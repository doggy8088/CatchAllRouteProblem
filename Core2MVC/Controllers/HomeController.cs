using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core2MVC.Controllers
{
    public class HomeController : Controller
    {
        [Route("{*path}")]
        public IActionResult Index(string path)
        {
            var url = Url.Action("Index", new { path = "hello/world" });
            return Content("Path = [" + path + "], built URL = " + url);
        }
    }
}
