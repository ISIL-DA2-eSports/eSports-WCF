using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebWCF_eSports.Heroe
{
    public partial class WebHeroeComplejidad : System.Web.UI.Page
    {
        ProxyHeroe.ServicioHeroeClient objHeroe = new ProxyHeroe.ServicioHeroeClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                grvDatos.DataSource = objHeroe.HeroeComplejidad(dplComplejidad.Text);
                grvDatos.DataBind();

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Jugador/WebPaisJugador.aspx");
        }
    }
}