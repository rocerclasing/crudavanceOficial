using Prueba.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba
{
    public partial class ValidarModificar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            String rut = Request["txtrut"];
            if (rut.Trim().Equals(""))
            {
                Response.Write("<h1>Campos vacios</h1>");
            }
            else
            {
                ProcesarBuscar pb = new ProcesarBuscar();

                Alumno encontrado = pb.validaBuscarAl(rut);

                if (encontrado != null)
                {
                    Response.Write("Rut Alumno: " + encontrado.Rut + "<br>");
                    Response.Write("Nombre Alumno: " + encontrado.Nombre + "<br>");
                    Response.Write("Apellido Alumno: " + encontrado.Apellido + "<br>");
                    Response.Write("Edad Alumno: " + encontrado.Edad.ToString() + "<br>");

                    if (rut.Equals(encontrado.Rut.ToString()))
                    {

                        String nombre = Request["txtnombre"];
                        String apellido = Request["txtapellido"];
                        String edad = Request["txtedad"];
                        int ed = Convert.ToInt32(edad);

                        Alumno a1 = new Alumno();

                        int res = a1.Modificar(rut, nombre, apellido, ed);

                        if (res > 0)
                        {

                            Response.Write("Modificado correctamente");

                        }
                        else
                        {

                            Response.Write("Error");

                        }

                    }
                else
                {
                    
                    }
                }
            }
        }
        
    }
  }

            

        
    






    