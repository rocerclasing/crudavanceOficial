using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba.Controladores
{
    public partial class ProcesarMostrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        public List<Alumno> mostrarAlum() {

            Alumno a = new Alumno();
            List<Alumno> lista = a.mostrar();
            return lista;

        }

        
    }
}