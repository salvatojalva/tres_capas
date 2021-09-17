using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P2.Model
{
    public class Asignacion
    {
        public int CodigoAsignacion { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public int Zona { get; set; }
        public int Final { get; set; }
        public int Total { get; set; }
        public string Resultado { get; set; }
        public bool EstadoDelegado { get; set; }
        public string CodigoAlumno { get; set; }
        public int CodigoProfesorCurso { get; set; }

    }
}