using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class Connection
    {
        private SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-TJ74E32\\SQLEXPRESS;Initial Catalog" +
            "= Northwind; Integrated Security = True");

        public SqlConnection OpenCon()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }

            return Conexion;
        }

        public SqlConnection CloseCon()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }

            return Conexion;
        }
    }
}
