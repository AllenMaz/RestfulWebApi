using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Padmate.Allen.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Default()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
