using Aula2405_EFMF.Controllers;
using Aula2405_EFMF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2405_EFMF.Views
{

    public partial class Cadastro : BasePage
    {
        
        //Categoria cat = new Categoria();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            /*string nome;
            string descricao;
            nome = txtNome.Text;
            descricao = txtNome.Text;
            */
            CategoriasController ctrl = new CategoriasController();
            Categoria cat = new Categoria();

            cat.Nome = txtNome.Text;
            cat.Descricao = txtDescricao.Text;
            cat.Ativo = true;
            ctrl.Adicionar(cat);
          
     
            //contexto.Categorias.Add(cat);
            //contexto.SaveChanges();
        }


        /*public string Salvar(string nome, string descricao)
        {
            Categoria cat = new Categoria();

            cat.Nome = txtNome.Text;
            cat.Descricao = txtDescricao.Text;

            contexto.Categorias.Add(cat);
            contexto.SaveChanges();

            return 
        }*/
    }
}
    
