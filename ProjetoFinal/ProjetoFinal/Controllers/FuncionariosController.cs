using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoFinal.Controllers
{

    public class FuncionariosController : BaseController
    {
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            if (funcionario != null)
            {
                contexto.Funcionarios.Add(funcionario);
                contexto.SaveChanges();
            }
        }

        public List<Funcionario> Listar()
        {
            return contexto.Funcionarios.ToList();
        }

        public Funcionario BuscarFuncionarioPorNome (Funcionario funcionario)
        {
            return contexto.Funcionarios.FirstOrDefault(m => m.Nome == funcionario.Nome);
        }

        public void Editar(Funcionario funcionario)
        {
            contexto.Entry(funcionario).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(Funcionario funcionario)
        {
            contexto.Entry(funcionario).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }
    }
}