using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema.Models
{
    public class Departamentos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Jefe { get; set; }
        public List<Empleados> Empleados { get; set; }
    }
}