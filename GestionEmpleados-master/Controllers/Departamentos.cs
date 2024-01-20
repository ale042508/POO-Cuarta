using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema.Controllers
{
    public class DepartamentoController : Controller
    {
        private List<Departamentos> ObtenerDepartamentos()
        {
            List<Departamentos> departamentos = new List<Departamentos>
        {
            new Departamentos { Id = 1, Nombre = "Ventas", Jefe = "Juan" },
            new Departamentos { Id = 2, Nombre = "Marketing", Jefe = "María" }
        };

            return departamentos;
        }

        public ActionResult Index()
        {
            List<Departamentos> departamentos = ObtenerDepartamentos();
            return View(departamentos);
        }
    }
}