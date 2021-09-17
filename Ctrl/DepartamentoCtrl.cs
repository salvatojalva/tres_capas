using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using P2.Model;

namespace P2.Ctrl
{
    public class DepartamentoCtrl
    {

        public static Departamento parseDepartamento( DataRow departamento_data)
        {

            Departamento departamento = new Departamento();

            departamento.CodigoDepartamento = int.Parse(departamento_data["cod_depto"].ToString());
            departamento.Nombre = departamento_data["nombre_depto"].ToString();

            return departamento;

        }
    }
}