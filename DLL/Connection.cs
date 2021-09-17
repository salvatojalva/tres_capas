using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace P2.DLL
{
    public class Connection
    {

        static string dbString = "Data Source=localhost;Initial Catalog=Parcial_II;User ID=sa;Password=Password.";

        public static string stringConnection
        {
            get { return dbString; }
        }


    }
}