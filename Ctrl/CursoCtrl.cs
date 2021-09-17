using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using P2.Model;

namespace P2.Ctrl
{
    public class CursoCtrl
    {

        public static Curso parseCurso(DataRow curso_data)
        {
            Curso curso = new Curso();

            curso.CodigoCurso = curso_data["codigo_curso"].ToString();
            curso.Nombre = curso_data["nombre_curso"].ToString();

            return curso;
        }
    }
}