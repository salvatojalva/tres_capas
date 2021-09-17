using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;

namespace P2.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string CodigoAlumno { get; set; }
        public string DPI { get; set; }
        public bool Active { get; set; }
        public bool Admin { get; set; }

    }
}