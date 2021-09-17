using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using P2.Model;

namespace P2.Ctrl
{
    public class CicloCtrl
    {

        public static Ciclo parseCiclo(DataRow ciclo_data)
        {
            Ciclo ciclo = new Ciclo();

            ciclo.CodigoCiclo = int.Parse( ciclo_data["codigo_curso"].ToString() );
            ciclo.NombreCiclo = ciclo_data["nombre_curso"].ToString();

            return ciclo;
        }

    }
}