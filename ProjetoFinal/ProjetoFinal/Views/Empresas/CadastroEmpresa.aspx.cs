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
        EmpresasController controller = new EmpresasController();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Empresa> lista = controller.Listar();
            gdvEmpresas.DataSource = lista.OrderBy(c => c.Id);
            gdvEmpresas.DataBind();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            empresa.Nome = txtNomeEmpresa.Text;
            controller.AdicionarEmpresa(empresa);
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Empresa empresa;
            using (var ctx = new BaseProjetoContainer())
            { 
                empresa = ctx.Empresas.Where(s => s.Nome == (txtExcluir.Text)).FirstOrDefault<Empresa>();
            }
            using (var novoCtx = new BaseProjetoContainer())
            {
                novoCtx.Entry(empresa).State = System.Data.Entity.EntityState.Deleted;
                novoCtx.SaveChanges();
            }
        }
    }

}