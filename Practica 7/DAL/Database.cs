using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Practica_7.Properties;
using System.Configuration;
using System.Data.SqlClient;

namespace Practica_7.DAL
{
    public class Database
    {
        public static string getStrConnection()
        {
            return Settings.Default.empleadosConnectionString;
        }

        public SqlConnection getConnection()
        {
            SqlConnection Con = new SqlConnection(getStrConnection());
            return Con;
        }

    }
}
