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
            AtualizaLista();
        }

        protected void AtualizaLista()
        {
            List<Funcionario> lista = controller.Listar();
            gdvFuncionarios.DataSource = lista.OrderBy(c => c.Id);
            gdvFuncionarios.DataBind();
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

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();
            func.Nome = txtNomeFuncionarioEditar.Text;
            func = controller.BuscarFuncionarioPorNome(func);
            if (func != null)
            {
                func.CPF = txtCpfFuncionarioEditado.Text;
                func.Nome = txtNomeFuncionarioEditado.Text;
                func.DataDeNascimento = txtDataDeNascimentoFuncionarioEditado.Text;
                func.EmpresaId = Convert.ToInt32(txtIdEmpresaFuncionarioEditado.Text);
                controller.Editar(func);
            }
            AtualizaLista();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();
            func.Nome = txtExcluir.Text;
            func = controller.BuscarFuncionarioPorNome(func);
            if (func != null)
            {
                controller.Excluir(func);
            }
            AtualizaLista();
        }
    }
}