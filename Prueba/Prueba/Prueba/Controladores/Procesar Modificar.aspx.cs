using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba.Controladores
{
    public partial class Procesar_Modificar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           

        }

        public int Modificar(String rut,String nombre,String apellido,int edad )
        {
            Alumno a = new Alumno();


            int res = a.Modificar(rut,nombre,apellido,edad);

            return res;
        }
    }
}