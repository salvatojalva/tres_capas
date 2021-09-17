using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using P2.Model;

namespace P2.Ctrl
{
    public class MunicipioCtrl
    {

        public static Municipio parseMunicipio( DataRow municipio_data )
        {
            Municipio municipio = new Municipio();

            municipio.CodigoMunicipio = municipio_data["cod_municipio"].ToString();
            municipio.NombreMunicipio = municipio_data["nombre_municipio"].ToString();
            municipio.CodigoDepartamento = int.Parse(municipio_data["cod_depto"].ToString());

            return municipio;
        }
    }
}