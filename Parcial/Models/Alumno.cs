using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Models
{
    public class Alumno
    {
        public int id { get; set; }
        public string nombre1 { get; set; }
        public string nombre2 { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string genero { get; set; }
        public int? carne { get; set; }
        public string carrera { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public DateTime fecha_nac { get; set; }
        public int? no_tel { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }

    }
}
