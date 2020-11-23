using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebWCF_eSports.Jugador
{
    public partial class WebRankingJugador : System.Web.UI.Page
    {
        ProxyJugador2.ServicioJugadorClient objJugador = new ProxyJugador2.ServicioJugadorClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                grvDatos.DataSource = objJugador.RankingJugador(Convert.ToInt16(dplTop.Text));
                grvDatos.DataBind();
            }
            catch (Exception ex)
            {

                lblMensaje.Text = ex.Message;
            }
        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Torneo/WebTorneoFecha.aspx");
        }
    }
}