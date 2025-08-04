using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventario.Controllers
{
    public class MiControladorController : Controller
    {
        // GET: MiControlador
        public ActionResult Index()
        {
            return View();
        }
    }
}