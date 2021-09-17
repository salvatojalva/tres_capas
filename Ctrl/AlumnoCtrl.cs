using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using P2.Model;
using System.Data;

namespace P2.Ctrl
{
    public class AlumnoCtrl
    {

        public static Alumno parseAlumno(DataRow alumno_data) 
        {
            Alumno alumno = new Alumno();

            alumno.CodigoAlumno = alumno_data["codigo_alumno"].ToString();
            alumno.Direccion = alumno_data["direccion"].ToString();
            alumno.Telefono = alumno_data["telefono"].ToString();
            alumno.CodigoAlumno = alumno_data["usuario_alumno"].ToString();
            alumno.Municipio = alumno_data["cod_municipio"].ToString();

            return alumno;
        }
    }
}