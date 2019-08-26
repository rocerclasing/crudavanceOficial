using Prueba.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba
{
    public partial class validaBuscar : System.Web.UI.Page
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

                   

                }
                else
                {

                    Response.Write("<h1>Alumno no existente</h1>");

                }





            }
        }
    }
}