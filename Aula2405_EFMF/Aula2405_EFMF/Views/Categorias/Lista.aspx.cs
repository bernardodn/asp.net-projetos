using Aula2405_EFMF.Controllers;
using Aula2405_EFMF.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula2405_EFMF.Views.Categorias
{
    public partial class Lista : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoriasController ctrl = new CategoriasController();
            List<Categoria> lista = ctrl.Listar();
            gdvCategorias.DataSource = lista.OrderBy(c => c.Nome);
            gdvCategorias.DataBind(); 
        }
    }
}