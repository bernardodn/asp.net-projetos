using ProjetoFinal.Controllers;
using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoFinal.Views.Empresas
{
    public partial class CadastroEmpresa : System.Web.UI.Page
    {
        EmpresasController controller = new EmpresasController();
        protected void Page_Load(object sender, EventArgs e)
        {
            AtualizaLista();
        }

        protected void AtualizaLista()
        {
            List<Empresa> lista = controller.Listar();
            gdvEmpresas.DataSource = lista.OrderBy(c => c.Id);
            gdvEmpresas.DataBind();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            empresa.CNPJ = txtCnpjEmpresa.Text;
            empresa.Nome = txtNomeEmpresa.Text;
            empresa.Descricao = txtDescricaoEmpresa.Text;
            controller.AdicionarEmpresa(empresa);
            AtualizaLista();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Empresa emp = new Empresa();
            emp.Id = Convert.ToInt32(txtIdEmpresaEditar.Text);
            emp = controller.BuscarEmpresaPorId(emp);
            if (emp != null)
            {
                emp.CNPJ = txtCnpjEmpresaEditado.Text;
                emp.Nome = txtNomeEmpresaEditado.Text;
                emp.Descricao = txtDescricaoEmpresaEditado.Text;
                controller.Editar(emp);                
            }
            AtualizaLista();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Empresa emp = new Empresa();
            emp.Id = Convert.ToInt32(txtExcluir.Text);
            emp = controller.BuscarEmpresaPorId(emp);
            if (emp != null)
            {
                controller.Excluir(emp);
            }
            AtualizaLista();
        }
    }

}