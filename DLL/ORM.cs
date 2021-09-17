using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Data;

namespace P2.DLL
{
    public class ORM
    {


        public static SqlCommand buildQuery()
        {
            string _cadenaConexion = Connection.stringConnection;
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;
            SqlCommand _command = new SqlCommand();
            _command = _conexion.CreateCommand();
            _command.CommandType = CommandType.Text;
            return _command;
        }

        public static SqlCommand doCommandProc(string proc)
        {
            string _cadenaConexion = Connection.stringConnection;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _command = new SqlCommand(proc, _conexion);
            _command.CommandType = CommandType.StoredProcedure;
            return _command;
        }


        public static int executeCommand(SqlCommand command)
        {
            try
            {
                command.Connection.Open();
                return command.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                command.Connection.Dispose();
                command.Connection.Close();
            }
        }

        public static DataTable executeQuery(SqlCommand command)
        {
            DataTable _tabla = new DataTable();
            try
            {
                command.Connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = command;
                adaptador.Fill(_tabla);
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { command.Connection.Close(); }
            return _tabla;
        }

    }


}