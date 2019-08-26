using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Prueba
{
    
    public class Conexion
    {
        private SqlConnection con;
        private SqlCommand comando;

        public Conexion()
        {
            con = new SqlConnection("Data Source=DESKTOP-FB0JERG;Initial Catalog=Prueba;Integrated Security=True");
            con.Open();

        }

        public SqlConnection Con { get => con; set => con = value; }

        public void cerrarConexion()
        {
            con.Close();
        }
        
    }
}