using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba.Controladores
{
    public partial class Procesarinsertar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String rut = Request["txtrut"];
            String nombre = Request["txtnombre"];
            String apellido = Request["txtapellido"];
            String edad = Request["txtedad"];
            if(rut.Trim().Equals("") )
            {
                Response.Write("<h1>Campos vacios</h1>");
            }
            else
            {
                int ed = 0;
                try
                {
                    ed = Int32.Parse(edad);
                }
                catch(FormatException ex)
                {
                    Response.Write("La edad debe ser numerica");
                }

                if(ed>0)
                {
                    Alumno a1 = new Alumno(rut,nombre,apellido,ed);
                    if(a1.insertar() >0)
                    {
                        Response.Write("Registrado correctamente");

                    }
                    else
                    {
                        Response.Write("No se pudo registrar");
                    }
                }
                else
                {
                    Response.Write("Debe ingresar una edad");
                }

            }
          

        }
    }
}