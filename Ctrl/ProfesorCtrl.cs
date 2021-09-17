using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using P2.Model;

namespace P2.Ctrl
{
    public class ProfesorCtrl
    {

        public static Profesor parseProfesor( DataRow profesor_data )
        {

            Profesor profesor = new Profesor();

            profesor.DpiProfesor = profesor_data["dpi_profesor"].ToString();
            profesor.Direccion = profesor_data["direccion_profesor"].ToString();
            profesor.Telefono = profesor_data["telefono_profesor"].ToString();
            profesor.Estado = bool.Parse(profesor_data["estado_profesor"].ToString());
            profesor.Usuario = profesor_data["usuario_profesor"].ToString();
            profesor.CodigoMunicipio = profesor_data["cod_municipio"].ToString();

            return profesor;
        }
    }
}