using ProjetoFinal.Controllers;
using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ProjetoFinal.Views.Empresas
{
    public partial class CadastroEmpresa : System.Web.UI.Page
    {
        protected BaseProjetoContainer contexto = new BaseProjetoContainer();
        protected void Page_Load(object sender, EventArgs e)
        {
            EmpresasController controller = new EmpresasController();
            List<Empresa> lista = controller.Listar();
            gdvEmpresas.DataSource = lista.OrderBy(c => c.Id);
            gdvEmpresas.DataBind();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            EmpresasController controller = new EmpresasController();
            Empresa empresa = new Empresa();

            empresa.Nome = txtNomeEmpresa.Text;
            controller.AdicionarEmpresa(empresa);
        }

        protected void btnRemover_Click(object sender, EventArgs e)
        {
           
        }


    }

}