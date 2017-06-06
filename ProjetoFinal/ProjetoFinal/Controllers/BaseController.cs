using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFinal.Controllers
{
    public class BaseController : System.Web.UI.Page
    {
        protected static BaseProjetoContainer contexto = new BaseProjetoContainer();
    }
}