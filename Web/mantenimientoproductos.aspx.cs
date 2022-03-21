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
    public partial class mantenimientoproductos : System.Web.UI.Page
    {

        private NegocioProductos negocio = new NegocioProductos();
        private EntidadRepuestos Entidad = new EntidadRepuestos();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            GridView1.DataSource = negocio.listarProductos();
         

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Desbloquear();
            Limpiar();
        }

        void Desbloquear ()
        {
            //txtcliente.Enabled = true;
            TextBox1.Enabled = true;
            TextBox2.Enabled = true;
            TextBox3.Enabled = true;
            Button2.Enabled = true;
        }

        void Bloquear ()
        {
            //txtcliente.Enabled = false;
            TextBox1.Enabled = false;
            TextBox2.Enabled = false;
            TextBox3.Enabled = false;
            Button2.Enabled = false;
            //Button3.Enabled = false;
            //Button4.Enabled = false;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Bloquear();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Entidad.Nombre = TextBox1.Text;
            Entidad.Tipo = int.Parse(TextBox2.Text);
            Entidad.Descripcion = TextBox3.Text;
            negocio.insertarRepuesto(Entidad);
            ScriptManager.RegisterStartupScript(this, typeof(System.Web.UI.Page), "Alerta", mensajescript("REGISTRO EXITOSO"), false);
            Limpiar();
        }

        public static string mensajescript(string mensaje)
        {
            string script5 = @"<script type='text/javascript'> alert('" + mensaje + "');</script>";
            return script5;
        }

        void Limpiar ()
        {
            txtcliente.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (txtcliente.Text == "")
            {

            }
            else
            {
                
                Entidad = negocio.consultarProducto(int.Parse(txtcliente.Text));
                TextBox1.Text = Entidad.Nombre;
                TextBox2.Text = Entidad.Tipo.ToString();
                TextBox3.Text = Entidad.Descripcion;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (txtcliente.Text == "")
            {

            }
            else
            {
                Entidad.Id = int.Parse(txtcliente.Text);
                Entidad.Nombre = TextBox1.Text;
                Entidad.Tipo = int.Parse(TextBox2.Text);
                Entidad.Descripcion = TextBox3.Text;
                negocio.actualizarRepuesto(Entidad);
                ScriptManager.RegisterStartupScript(this, typeof(System.Web.UI.Page), "Alerta", mensajescript("REGISTRO ACTUALIZADO"), false);
                Limpiar();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (txtcliente.Text == "")
            {

            }
            else
            {
                Entidad.Id = int.Parse(txtcliente.Text);
                negocio.eliminarRepuesto(Entidad);
                ScriptManager.RegisterStartupScript(this, typeof(System.Web.UI.Page), "Alerta", mensajescript("REGISTRO ELIMINADO"), false);
                Limpiar();
            }
        }
    }
}