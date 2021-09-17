using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using P2.Model;

namespace P2.Ctrl
{
    public class ProfesorCursoCtrl
    {

        public static ProfesorCurso parseProfesorCurso( DataRow profesor_curso_data)
        {

            ProfesorCurso profesor_curso = new ProfesorCurso();

            profesor_curso.CodigoProfesorCurso = int.Parse(profesor_curso_data["codigo_prof_curso"].ToString());
            profesor_curso.FechaAsignacion = DateTime.Parse(profesor_curso_data["fecha_asignacion"].ToString());
            profesor_curso.CodigoCiclo = int.Parse(profesor_curso_data["codigo_ciclo"].ToString());
            profesor_curso.DpiProfesor = profesor_curso_data["dpi_profesor"].ToString();
            profesor_curso.CodigoCurso = profesor_curso_data["codigo_curso"].ToString();

            return profesor_curso;
        }
    }
}