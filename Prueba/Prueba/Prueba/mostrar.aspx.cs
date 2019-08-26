using Prueba.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba
{
    public partial class mostrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProcesarMostrar pm = new ProcesarMostrar();

            List<Alumno> lista = pm.mostrarAlum();

            foreach (Alumno a in lista)
            {

                Response.Write("Rut:" + a.Rut);
                Response.Write("Nombre:" + a.Nombre);
                Response.Write("Apellido:" + a.Apellido);
                Response.Write("Edad:" + a.Edad);
                Response.Write("<br>");

             


            }

            Response.Write("Lista:"+lista.Count);

        }
    }
}