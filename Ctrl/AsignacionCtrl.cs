using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using P2.Model;

namespace P2.Ctrl
{
    public class AsignacionCtrl
    {


        public static Asignacion parseAsignacion(DataRow asigacion_data)
        {
            Asignacion asignacion = new Asignacion();

            asignacion.CodigoAsignacion = Int32.Parse(asigacion_data["codigo_asignacion"].ToString());
            asignacion.FechaAsignacion = DateTime.Parse(asigacion_data["fecha_asignacion"].ToString());
            asignacion.Zona = Int32.Parse(asigacion_data["zona"].ToString());
            asignacion.Final = Int32.Parse(asigacion_data["final"].ToString());
            asignacion.Total = Int32.Parse(asigacion_data["total"].ToString());
            asignacion.Resultado = asigacion_data["resultado"].ToString();
            asignacion.EstadoDelegado = bool.Parse(asigacion_data["estado_deletado"].ToString());
            asignacion.CodigoAlumno = asigacion_data["codigo_alumno"].ToString();
            asignacion.CodigoProfesorCurso = Int32.Parse(asigacion_data["codigo_prof_curso"].ToString());

            return asignacion;
        }
    }
}