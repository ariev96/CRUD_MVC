using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Indimaret.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //hardcode session karna blm buat login harusnya didapat dari login
            //Session["ID"] = "1";
            return View();
        }
    }
}