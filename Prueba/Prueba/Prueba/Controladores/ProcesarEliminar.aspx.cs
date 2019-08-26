using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba.Controladores
{
    public partial class ProcesarEliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        public int Eliminar(string rut)
        {

          
            Alumno a = new Alumno();
           

            int res = a.Eliminar(rut);

            return res;


        }
    }
}