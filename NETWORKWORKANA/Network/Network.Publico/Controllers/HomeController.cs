using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Network.Publico.Controllers
{

    public class HomeController : Controller
    {
        private readonly Network.Application.UsuarioApplication usuarioApp;
        // GET: Home
        public HomeController()
        {
            this.usuarioApp = new Application.UsuarioApplication();
        }
        public ActionResult Index()
        {
            return View(this.usuarioApp.ListarTodos());
        }
    }
}