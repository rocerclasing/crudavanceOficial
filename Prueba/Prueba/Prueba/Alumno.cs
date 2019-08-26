using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Prueba
{

    public class Alumno
    {
        private String rut;
        private String nombre;
        private String apellido;
        private int edad;

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }

        public Alumno()
        {


        }

        public Alumno(String rut, String nombre, String apellido, int edad)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }



        public int insertar()
        {
            Conexion con = new Conexion();
            try
            {
                String query = "insert into Alumno values('" + this.rut + "','" + this.nombre + "','" + this.apellido + "'," + this.edad + ")";
                SqlCommand comando = new SqlCommand(query, con.Con);
                return comando.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                return -1;
            }
            finally
            {
                con.cerrarConexion();
            }
        }


        public Alumno buscar(String rut)
        {
            Conexion con = new Conexion();
            Alumno aEcontrado = null;
            try
            {
                
                String query = "Select * from Alumno where rut = ('" + rut + "')";
                SqlCommand comando = new SqlCommand(query, con.Con);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    aEcontrado = new Alumno();
                    aEcontrado.Rut = reader[0].ToString();
                    aEcontrado.Nombre = reader[1].ToString();
                    aEcontrado.Apellido = reader[2].ToString();
                    aEcontrado.Edad = Convert.ToInt32(reader[3].ToString());

                }
                return aEcontrado;
            }
            catch(SqlException ex)
            {
                return aEcontrado;
            }

        }

        public int Eliminar(String rut)
        {
            Conexion con = new Conexion();

            int res = 0;
            try
            {
                String query = "delete from Alumno where rut = '" + rut + "'";
                SqlCommand cmd = new SqlCommand(query, con.Con);
                res = cmd.ExecuteNonQuery();
                return res;

            }

            catch (Exception e)
            {
                return -1;
            }
            finally
            {
                con.cerrarConexion();
            }


        }


        public int Modificar(String rut,String nombre,String apellido,int edad)
        {
            Conexion con = new Conexion();
            int res = 0;
            try
            {
                String query = "update Alumno set rut='" + rut + "',nombre = '" + nombre + "', apellido = '" + apellido + "', edad=" + edad + " where rut='" + rut + "'";
                SqlCommand cmd = new SqlCommand(query, con.Con);
                res = cmd.ExecuteNonQuery();
                return res;
                
            }
            catch(Exception ex)
            {
                return -1;
            }
            finally
            {
                con.cerrarConexion();
            }
        }


        public List<Alumno> mostrar()
        {
            Conexion con = new Conexion();
            List<Alumno> lista = new List<Alumno>();
            try
            {
                String query = "select * from Alumno";
                SqlCommand comando = new SqlCommand(query, con.Con);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    Alumno a = new Alumno();
                    a.Rut = reader[0].ToString();
                    a.Nombre = reader[1].ToString();
                    a.Apellido = reader[2].ToString();
                    a.Edad = Convert.ToInt32(reader[3].ToString());
                    lista.Add(a);
                }

                return lista;
            }
            catch (SqlException ex)
            {
                return lista;
            }
            finally
            {
                con.cerrarConexion();
            }
        }

    }
}