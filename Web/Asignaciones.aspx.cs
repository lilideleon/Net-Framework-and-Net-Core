using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidad;
using System.Data;

namespace Web
{
    public partial class Asignaciones : System.Web.UI.Page
    {
        private NegocioAsociar negocio = new NegocioAsociar();
        private EntidadAsociar Entidad = new EntidadAsociar();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Entidad.Producto = int.Parse(TextBox1.Text);
            Entidad.Existencia = int.Parse(TextBox2.Text);
            Entidad.Bodega = int.Parse(TextBox3.Text);
            Entidad.Ubicacion = TextBox4.Text;
            Entidad.Minimo = int.Parse(TextBox5.Text);
            Entidad.Maximo = int.Parse(TextBox6.Text);
            Entidad.precio = int.Parse(TextBox7.Text);
            negocio.insertarRepuesto(Entidad);
            ScriptManager.RegisterStartupScript(this, typeof(System.Web.UI.Page), "Alerta", mensajescript("REGISTRO EXITOSO"), false);
           
        }

        public static string mensajescript(string mensaje)
        {
            string script5 = @"<script type='text/javascript'> alert('" + mensaje + "');</script>";
            return script5;
        }
    }
}