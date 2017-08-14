using Network.Dommain;
using Network.Publico.InfraStructre;
using Network.Publico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Network.Publico.Controllers
{
    public class LoginController : Controller
    {
        private readonly Network.Application.UsuarioApplication usuarioApp;

        public LoginController()
        {
            this.usuarioApp = new Application.UsuarioApplication();
        }
        // GET: Login
        public ActionResult Index()
        {
            return View(new networkusuario());
        }

        [HttpPost]
        public ActionResult Index(networkusuario dto)
        {
            //dto.Cpf = StringHelper.FormatarCpf(dto.Cpf);
            var retorno = this.usuarioApp.Login(dto.Cpf, dto.Senha);

            if (retorno != null)
            {
                LoginModels.SetLoginModel(new LoginModels
                {
                    IdUsuario = retorno.IdUsuario,
                    NomeFuncionario = retorno.NomeFuncionario,
                    Bairro = retorno.Bairro,
                    CarteiraMotorista = retorno.CarteiraMotorista,
                    Carteiratrabalho = retorno.Carteiratrabalho,
                    Cidade = retorno.Cidade,
                    CodigoFuncionario = retorno.CodigoFuncionario,
                    Cpf = retorno.Cpf,
                    DataEmaissao = retorno.DataEmaissao,
                    Endereco = retorno.Endereco,
                    Fone1 = retorno.Fone1,
                    Fone2 = retorno.Fone2,
                    Perfil = retorno.Perfil

                });
            }

            if (LoginModels.IsLogado())
                return RedirectToAction("index", "home");
            else
            {
                TempData["error"] = "Nenhum usuário encontrado.";
                return View(dto);
            }
        }

        public ActionResult RecuperarSenha()
        {
            return View(new networkusuario());
        }

        [HttpPost]
        public ActionResult RecuperarSenha(networkusuario dto)
        {
            var retorno = this.usuarioApp.ListarPorEmail(dto.Email);

            if (retorno != null)
            {
                var mensagem = string.Format(
                    "<p>Prezado(a), {0},<br><br>Segue abaixo suas informações de acesso.<br><br>CPF: {1}<br>Senha: {2}</p>",
                        retorno.NomeFuncionario, retorno.Cpf, retorno.Senha);

                TempData["sucesso"] = InfraStructre.Send.EnviarSenha(retorno.Email, mensagem, "Infromações de Acesso");
            }
            else
                TempData["error"] = "Nenhum usuário encontrado.";

            return View(dto);
        }

        public ActionResult Logoff()
        {
            LoginModels.LogOff();
            return RedirectToAction("index", "Login");
        }
    }
}