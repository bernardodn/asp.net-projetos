using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1705
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int valor1ViewState = Convert.ToInt32(ViewState["valor1"]);
            int valor2ViewState = Convert.ToInt32(ViewState["valor1"]);
            int valorSession = Convert.ToInt32(Session["valorSession"]);
            int resultadoViewState = Convert.ToInt32(ViewState["resultado"]);
            int resultadoSession = Convert.ToInt32(Session["resultadoSession"]);
            lblResultado.Text = valorSession.ToString();
        }
    }
}