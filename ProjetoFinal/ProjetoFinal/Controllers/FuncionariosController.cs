using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public static implicit operator FuncionariosController(EmpresasController v)
        {
            throw new NotImplementedException();
        }
    }
}