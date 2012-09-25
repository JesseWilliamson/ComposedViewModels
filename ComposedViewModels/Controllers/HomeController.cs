using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComposedViewModels.Models;

namespace ComposedViewModels.Controllers
{
    public class HomeController : Controller
    {
        Person _person;

        public HomeController(Person person)
        {
            _person = person;
        }

        public ActionResult Index()
        {
            return View(_person);
        }

    }
}
