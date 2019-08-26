using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba
{
    public partial class Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnrut_Click(object sender, EventArgs e)
        {
            Alumno a1 = new Alumno();
            String rut = txtrut.Text.ToString();
            if(a1.Equals(rut))
            {
                a1.Eliminar(rut);
                Response.Write("Rut eliminado");
            }
            else
            {
                Response.Write("no se puede eliminar rut");
            }
        }
    }
}