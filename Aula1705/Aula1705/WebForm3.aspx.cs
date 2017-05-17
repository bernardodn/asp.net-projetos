using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1705
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        double valor1;
        double valor2;
        double resultado;
        //string operacao;
        public int Valor1
        {
            get
            {
                return Convert.ToInt32(ViewState["valor1"]);
            }
            set
            {
                ViewState["valor1"] = value;
            }
        }
        public int Valor2
        {
            get
            {
                return Convert.ToInt32(ViewState["valor2"]);
            }
            set
            {
                ViewState["valor2"] = value;
            }
        }
        public int Resultado
        {
            get
            {
                return Convert.ToInt32(ViewState["resultado"]);
            }set
            {
                ViewState["resultado"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
                Valor1 = 0;
                //Valor2 = 0;
            }
        }
        protected void btnSoma_Click(object sender, EventArgs e)
        {
            //operacao = "+";
            Valor1 = int.Parse(txtValor1.Text);
            Valor2 = int.Parse(txtValor2.Text);
            resultado = Valor1 + Valor2;
            lblResult.Text = resultado.ToString();
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
            lblResult.Text = resultado.ToString();
            //Session.Add("valorSession", Valor1);
            //Session.Add("valorSession", Valor2);
            Session.Add("resultadoSession", resultado);
            Response.Redirect("~/WebForm4.aspx");
        }
    }
}