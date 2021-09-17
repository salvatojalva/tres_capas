using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P2.Model
{
    public class ProfesorCurso
    {
        public int CodigoProfesorCurso { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public int CodigoCiclo { get; set; }
        public string DpiProfesor { get; set; }
        public string CodigoCurso { get; set; }
    }
}