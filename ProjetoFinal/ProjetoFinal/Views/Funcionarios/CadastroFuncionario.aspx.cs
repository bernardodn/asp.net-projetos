using ProjetoFinal.Controllers;
using ProjetoFinal.Models;
using System;

namespace ProjetoFinal.Views.Funcionarios
{
    public partial class CadastroFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            FuncionariosController controller = new FuncionariosController();
            Funcionario funcionario = new Funcionario();

            funcionario.CPF = txtCpfFuncionario.Text;
            funcionario.Nome = txtNomeFuncionario.Text;
            funcionario.DataDeNascimento = txtDataDeNascimentoFuncionario.Text;

            controller.AdicionarFuncionario(funcionario);

        }
    }
}