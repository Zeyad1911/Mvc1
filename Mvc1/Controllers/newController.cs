using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc1.Controllers
{
    public class newController : Controller
    {
        // GET: new
        public ActionResult Index()
        {
            AdventureWorks2017Entities a = new AdventureWorks2017Entities();
            var item = a.People.ToList();
            return View(item);
        }
    }
}