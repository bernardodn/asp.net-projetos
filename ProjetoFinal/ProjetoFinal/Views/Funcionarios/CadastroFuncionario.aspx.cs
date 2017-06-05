using ProjetoFinal.Controllers;
using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoFinal.Views.Funcionarios
{
    public partial class CadastroFuncionario : System.Web.UI.Page
    {
        FuncionariosController controller = new FuncionariosController();
        protected void Page_Load(object sender, EventArgs e)
        {
            //List<Funcionario> lista = controller.Listar();
            //gdvFuncionarios.DataSource = lista.OrderBy(c => c.Id);
            //gdvFuncionarios.DataBind();
            AtualizaLista();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            
            Funcionario funcionario = new Funcionario();

            funcionario.CPF = txtCpfFuncionario.Text;
            funcionario.Nome = txtNomeFuncionario.Text;
            funcionario.DataDeNascimento = txtDataDeNascimentoFuncionario.Text;
            funcionario.EmpresaId = Convert.ToInt32(txtIdEmpresaFuncionario.Text);

            controller.AdicionarFuncionario(funcionario);
            AtualizaLista();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Funcionario funcionario;
            using (var ctx = new BaseProjetoContainer())
            {
                funcionario = ctx.Funcionarios.Where(s => s.Nome == (txtExcluir.Text)).FirstOrDefault<Funcionario>();
            }
            using (var novoCtx = new BaseProjetoContainer())
            {
                novoCtx.Entry(funcionario).State = System.Data.Entity.EntityState.Deleted;
                novoCtx.SaveChanges();
            }
            AtualizaLista();
        }

        protected void AtualizaLista()
        {
            List<Funcionario> lista = controller.Listar();
            gdvFuncionarios.DataSource = lista.OrderBy(c => c.Id);
            gdvFuncionarios.DataBind();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            using (var novoCtx = new BaseProjetoContainer())
            {
                var result = novoCtx.Funcionarios.SingleOrDefault(b => b.CPF == (txtCpfFuncionario.Text));
                if (result != null)
                {
                    result.CPF = txtCpfFuncionario.Text;
                    result.Nome = txtNomeFuncionario.Text;
                    result.DataDeNascimento = txtDataDeNascimentoFuncionario.Text;
                    result.EmpresaId = Convert.ToInt32(txtIdEmpresaFuncionario.Text);
                    novoCtx.SaveChanges();
                }
            }
            AtualizaLista();
        }
    }
}