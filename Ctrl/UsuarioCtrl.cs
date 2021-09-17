using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Data;
using P2.Model;

namespace P2.Ctrl
{
    public class UsuarioCtrl
    {
        public static Usuario login(string usuario, string pass)
        {
            DataRow user = null;

            SqlCommand query = DLL.ORM.buildQuery();
            query.CommandText = "SELECT * FROM Usuario WHERE usuario = '" + usuario+ "' AND password = '" + pass+"'";

            DataTable users = DLL.ORM.executeQuery(query);

            foreach (DataRow row in users.Rows) {
                user = row;
            }

            if (user != null) return parseUsuario(user);

            return null;
        }
        public static DataTable getById(int id)
        {
            SqlCommand query = DLL.ORM.buildQuery();
            query.CommandText = "SELECT * FROM Usuario WHERE usuario_id = " + id ;
            return DLL.ORM.executeQuery(query);
        }

        public static Usuario parseUsuario(DataRow user)
        {
            Usuario usuario_ret = new Usuario();

            usuario_ret.Id = Int32.Parse(user["usuario_id"].ToString());
            usuario_ret.User = user["usuario"].ToString();
            usuario_ret.Password = user["password"].ToString();
            usuario_ret.Nombres = user["nombres"].ToString();
            usuario_ret.Apellidos = user["apellidos"].ToString();
            usuario_ret.CodigoAlumno = user["codigo_alumno"].ToString();
            usuario_ret.DPI = user["dpi_profesor"].ToString();
            usuario_ret.Active = bool.Parse(user["is_active"].ToString());
            usuario_ret.Admin = bool.Parse(user["is_admin"].ToString());

            return usuario_ret;
        }
    }

}