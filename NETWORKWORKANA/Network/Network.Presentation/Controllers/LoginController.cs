using Network.Dommain;
using Network.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Network.Presentation.Controllers
{
    public class LoginController : BaseController
    {
        // GET: Login
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
                    Perfil = retorno.Perfil,
                    Email = retorno.Email,
                    Sexo = retorno.Sexo,
                    Status = retorno.Status,
                    Rg = retorno.Rg,
                    

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

        //public ActionResult Cadastre()
        //{
        //    var model = new LoginModels();

        //    model.DdSexo = SexoLista();

        //    return View(model);
        //}

        //[HttpPost]
        //public ActionResult Cadastre(networkusuario model)
        //{
        //    if (this.usuarioApp.Existe(model.Cpf))
        //    {
        //        TempData["msgsucesso"] = "CPF já cadastrado.";
        //        return View(model);
        //    }

        //    if (custom.ValidationCPF.IsCpf(model.Cpf))
        //    {
        //        try
        //        {
        //            model.DdSexo = SexoLista();

        //            var dto = new Pessoa_Dto
        //            {
        //                Nome = model.Nome,
        //                Cpf = StringHelper.FormatarCpf(model.Cpf),
        //                IdTipoPessoa = 2,
        //                Endereco = model.Endereco,
        //                Email = model.Email,
        //                Sexo = model.Sexo,
        //                Cep = model.Cep,
        //                Telefone = model.Telefone,
        //                Ativo = true,
        //                senha = model.Senha,
        //                DataCadastro = DateTime.Now
        //            };


        //            if (ModelState.IsValid)
        //            {
        //                this._pessoaBusiness.Salvar(dto);

        //                var retorno = this._pessoaBusiness.Login(dto.senha, dto.Cpf);

        //                LoginModels.SetLoginModel(new LoginModels
        //                {
        //                    Id = retorno.Id,
        //                    Nome = retorno.Nome,
        //                    Email = retorno.Email,
        //                    Cpf = retorno.Cpf,
        //                    Senha = retorno.senha,
        //                    IdTipoPessoa = retorno.IdTipoPessoa,
        //                    DescricaoTipoPessoa = "Cliente".ToLower()
        //                });

        //                if (LoginModels.IsLogado())
        //                    return RedirectToAction("index", "home");
        //            }
        //        }
        //        catch (Exception exception)
        //        {
        //            TempData["msgerror"] = exception.Message.ToString();
        //            return View(model);
        //        }
        //    }
        //    else
        //    {
        //        TempData["msgerror"] = "Cpf invalido";
        //    }

        //    return View(model);
        //}

    }
}
