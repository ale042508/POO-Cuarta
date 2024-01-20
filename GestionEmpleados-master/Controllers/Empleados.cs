using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema.Controllers
{
    public class EmpleadoController : Controller
    {
        private List<Empleados> ObtenerEmpleados()
        {
            List<Empleados> empleados = new List<Empleados>
        {
            new Empleados { Id = 1, Nombre = "Juan Pérez", Edad = 30, Departamento = "Ventas" },
            new Empleados { Id = 2, Nombre = "María Gómez", Edad = 25, Departamento = "Marketing" },
            new Empleados { Id = 3, Nombre = "Pedro López", Edad = 28, Departamento = "Ventas" },
            new Empleados { Id = 4, Nombre = "Ana Martínez", Edad = 27, Departamento = "Marketing" }
        };

            return empleados;
        }

        public ActionResult Index()
        {
            List<Empleados> empleados = ObtenerEmpleados(); // Llama a la función para obtener la lista de empleados.
            return View(empleados);
        }
    }

}