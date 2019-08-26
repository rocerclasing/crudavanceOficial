using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba.Controladores
{
    public partial class ProcesarBuscar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        

        }


        public Alumno validaBuscarAl(string rut) {


            Alumno a = new Alumno();

            Alumno aEcontrado = a.buscar(rut);

            return aEcontrado;


        }
    }
}