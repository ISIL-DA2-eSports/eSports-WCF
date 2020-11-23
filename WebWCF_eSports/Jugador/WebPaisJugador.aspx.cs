using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebWCF_eSports.Jugador
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ProxyJugador.ServicioJugadorClient objJugador = new ProxyJugador.ServicioJugadorClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                grvDatos.DataSource = objJugador.ListarPaisJugadores(cbPais.Text);
                grvDatos.DataBind();

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebJugadorPorEdad.aspx");
        }
    }
}