using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APPGestionEMS.Models
{
    public class Cursos
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int Capacidad { get; set; }
        public int NumAlumnos { get; set; }
    }
}