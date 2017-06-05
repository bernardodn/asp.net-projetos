using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFinal.Controllers
{
    public class BaseController
    {
        protected static BaseProjetoContainer contexto = new BaseProjetoContainer();
    }
}