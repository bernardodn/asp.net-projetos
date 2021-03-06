﻿using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoFinal.Controllers
{
    public class EmpresasController: BaseController
    {        public void AdicionarEmpresa(Empresa empresa)
        {
            if (empresa != null)
            {
                contexto.Empresas.Add(empresa);
                contexto.SaveChanges();
            }
        }
        public List<Empresa> Listar()
        {
            return contexto.Empresas.ToList();
        }

        public Empresa BuscarEmpresaPorId(Empresa empresa)
        {
            int id = empresa.Id;
            return contexto.Empresas.Find(id);
        }

        public void Editar(Empresa empresa)
        {
            contexto.Entry(empresa).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir (Empresa empresa)
        {
            contexto.Entry(empresa).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }
    }
}