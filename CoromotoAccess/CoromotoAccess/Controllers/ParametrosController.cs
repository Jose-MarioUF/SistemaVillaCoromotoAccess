using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoromotoAccess.Controllers
{
    public class ParametrosController : Controller
    {
        // GET: Parametros
        public ActionResult HojaDeConfiguracion()
        {
            return View();
        }
    }
}