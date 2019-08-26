using Prueba.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba
{
    public partial class validarEliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String rut = Request["txtrut"];

            ProcesarEliminar pe = new ProcesarEliminar();

            int respuesta = pe.Eliminar(rut);

            if (respuesta > 0)
            {
                Response.Write("<h1>Alumno eliminado con éxito</h1> ");
            }
            else {

                Response.Write("<h1>Error al eliminar alumno</h1> ");


            }

        }
    }
}