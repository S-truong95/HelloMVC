using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class GreetController : Controller
    {
        //public ViewResult Index(string name)
        //{
        //    return View();
        //}

        //public ViewResult Index(string name)
        //{
        //    var model = new GreetingModel();
        //    return View(model);
        //}

        public ViewResult Index(string name)
        {
            var model = new GreetingModel();
            model.Name = name;
            return View(model);
        }
    }
}
