using Aula1406.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Aula1406.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias (GET = Carregamento da página)
        public ActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>();
            // retornar a lista de objetos cadastrados
            return View(categorias);
        }
        // GET
        public ActionResult Create()
        {
            return View();
        }
        // POST
        [HttpPost]
        public ActionResult Create(Categoria categoria) /*(string nome, string descricao, bool ativo) */ /*(FormCollection campos) recuperar campo a campo, sem ter model*/
        {
            if (ModelState.IsValid)
            {
                // insert
            }
            return View(categoria);
        }

        // GET

        public ActionResult Edit(int? id)
        {
            // verificar se veio id => BadRequest
            if (id == null)
            {
                // 400
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // pesqusia na fonte de dados o objeto a editar
            Categoria categoria = new Categoria() { CategoriaId = id.Value, Nome = "Carros", Descricao = "Super carros", Ativo = true };
            // se objeto nao foi encontrado na fonte de dados
            if (categoria == null)
            {
                // 404
                return HttpNotFound();
            }

            return View(categoria);
        }

        // POST
        [HttpPost]
        public ActionResult Edit(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // fazer update na fonte de dados
                    // redirecionar
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return View(categoria);
        }

        // GET

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Categoria categoria = new Categoria() { CategoriaId = id.Value, Nome = "Carros", Descricao = "Super carros", Ativo = true };

            if (categoria == null)
            {
                return HttpNotFound();
            }


            return View(categoria);
        }
        
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed (int id)
        {
            // pesquisar objeto por id

            // alterar status do objeto para deleted ou ativo para falso


            TempData["Mensagem"]= "Categoria excluida com sucesso";
            return RedirectToAction("Index");
        }

    }
}