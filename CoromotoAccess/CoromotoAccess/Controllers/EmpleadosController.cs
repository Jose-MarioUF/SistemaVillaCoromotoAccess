using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoromotoAccess.Controllers
{
    public class EmpleadosController : Controller
    {
        // GET: Empleados
        public ActionResult GestionEmpleados()
        {
            return View();
        }
        public ActionResult ModificarEmpleado()
        {
            return View();
        }
    }
}