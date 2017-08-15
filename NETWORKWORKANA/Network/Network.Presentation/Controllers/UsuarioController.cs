using CrossCounting.Helpers;
using Network.Dommain;
using Network.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Network.Presentation.Controllers
{
    public class UsuarioController : BaseController
    {
        private readonly Application.UsuarioApplication usuarioApp;
        private readonly Application.PerfilApplication perfilApp;

        // GET: Cliente
        public UsuarioController()
        {
            this.usuarioApp = new Application.UsuarioApplication();
            this.perfilApp = new Application.PerfilApplication();
        }
        public ActionResult Index()
        {
            var model = new List<UsuarioModels>();

            foreach (var item in this.usuarioApp.ListarTodos())
            {
                var objeto = new UsuarioModels
                {

                    IdUsuario = item.IdUsuario,
                    NomeFuncionario = item.NomeFuncionario,
                    CodigoFuncionario = item.CodigoFuncionario,
                    Setor = item.Setor,
                    DataEmissao = item.DataEmissao,
                    Salario = item.Salario,
                    Carteiratrabalho = item.Carteiratrabalho,
                    CarteiraMotorista = item.CarteiraMotorista,
                    Rg = item.Rg,
                    Cpf = item.Cpf,
                    Endereco = item.Endereco,
                    Bairro = item.Bairro,
                    Cidade = item.Cidade,
                    Ud = item.Ud,
                    Fone1 = item.Fone1,
                    Fone2 = item.Fone2,
                    Senha = item.Senha,
                    Perfil = item.Perfil,
                    Email = item.Email,
                    Cargo = item.Cargo,


                };
                model.Add(objeto);
            }
            return View(model);
        }
        public ActionResult Create()
        {
            var model = new UsuarioModels();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(UsuarioModels model)
        {


            try
            {

                var dto = new networkusuario
                {
                    IdUsuario = model.IdUsuario,
                    NomeFuncionario = model.NomeFuncionario,
                    CodigoFuncionario = model.CodigoFuncionario,
                    Setor = model.Setor,
                    DataEmissao = model.DataEmissao,
                    Salario = model.Salario,
                    Carteiratrabalho = model.Carteiratrabalho,
                    CarteiraMotorista = model.CarteiraMotorista,
                    Rg = model.Rg,
                    Cpf = model.Cpf,
                    Endereco = model.Endereco,
                    Bairro = model.Bairro,
                    Cidade = model.Cidade,
                    Ud = model.Ud,
                    Fone1 = model.Fone1,
                    Fone2 = model.Fone2,
                    //Status = model.Status,
                    Senha = model.Senha,
                    Perfil = model.Perfil,
                    Email = model.Email,
                    //Sexo = model.Sexo,
                };


                if (ModelState.IsValid)
                {
                    this.usuarioApp.Salvar(dto);
                    TempData["msgsucesso"] = "Registro salvo com sucesso";
                }

                //model.Nome = string.Empty;
                //model.Descricao = string.Empty;
                //model.ISBN = string.Empty;
                //model.Autor = string.Empty;
                //model.Editora = string.Empty;
                //model.Ativo = false;
                //model.Quantidade = 0;

                return RedirectToAction("create");
            }
            catch (Exception execption)
            {
                TempData["msgerror"] = execption.Message.ToString();

                return View(model);
            }
        }

        //public ActionResult Editar(int id)
        //{
        //    var filtro = this.usuarioApp.ListarPorId(id);

        //    var model = new UsuarioModels
        //    {
        //        IdUsuario = filtro.IdUsuario,
        //        NomeFuncionario = filtro.NomeFuncionario,
        //        CodigoFuncionario = filtro.CodigoFuncionario,
        //        Setor = filtro.Setor,
        //        DataEmissao = filtro.DataEmissao,
        //        Salario = filtro.Salario,
        //        Carteiratrabalho = filtro.Carteiratrabalho,
        //        CarteiraMotorista = filtro.CarteiraMotorista,
        //        Rg = filtro.Rg,
        //        Cpf = filtro.Cpf,
        //        Endereco = filtro.Endereco,
        //        Bairro = filtro.Bairro,
        //        Cidade = filtro.Cidade,
        //        Ud = filtro.Ud,
        //        Fone1 = filtro.Fone1,
        //        Fone2 = filtro.Fone2,
        //        //Status = filtro.Status,
        //        Senha = filtro.Senha,
        //        Perfil = filtro.Perfil,
        //        Email = filtro.Email,
        //        //Sexo = filtro.Sexo,
        //    };

        //    //model.DdlOperadora = OperadoraLista();
        //    //model.DdlTipoPessoa = TipoPessoaLista();
        //    //model.DdlUFLista = UFLista(this._ufApp.ListarTodos());
        //    //model.DdlPerfil = PerfilLista(this._perfilApp.ListarTodos());
        //    //model.DdlTipoEnderecoLista = TipoEnderecoLista();
        //    //model.DdlTipoTelefoneLista = TipoTelefoneLista();

        //    return View(model);
        //}
        //[HttpPost]
        //public ActionResult Editar(UsuarioModels model)
        //{


        //    try
        //    {
        //        var filtro = this.usuarioApp.ListarPorId(model.IdUsuario);

        //        filtro.IdUsuario = model.IdUsuario;
        //        filtro.NomeFuncionario = model.NomeFuncionario;
        //        filtro.CodigoFuncionario = model.CodigoFuncionario;
        //        filtro.Setor = model.Setor;
        //        filtro.DataEmissao = model.DataEmissao;
        //        filtro.Salario = model.Salario;
        //        filtro.Carteiratrabalho = model.Carteiratrabalho;
        //        filtro.CarteiraMotorista = model.CarteiraMotorista;
        //        filtro.Rg = model.Rg;
        //        filtro.Cpf = model.Cpf;
        //        filtro.Endereco = model.Endereco;
        //        filtro.Bairro = model.Bairro;
        //        filtro.Cidade = model.Cidade;
        //        filtro.Ud = model.Ud;
        //        filtro.Fone1 = model.Fone1;
        //        filtro.Fone2 = model.Fone2;
        //        //filtro.//Status = model.Status;
        //        filtro.Senha = model.Senha;
        //        filtro.Perfil = model.Perfil;
        //        filtro.Email = model.Email;
        //        //filtro.//Sexo = model.Sexo;

        //        if (ModelState.IsValid)
        //        {
        //            this.usuarioApp.Atualizar(filtro);
        //            TempData["msgsucesso"] = "Registro atualizado com sucesso!";

        //        }


        //        return View(model);
        //    }
        //    catch (Exception exception)
        //    {
        //        TempData["msgerror"] = exception.Message.ToString();
        //        return View(model);
        //    }
        //}

        //public ActionResult Details(int id)
        //{
        //    var filtro = this.usuarioApp.ListarPorId(id);

        //    var model = new UsuarioModels
        //    {
        //        IdUsuario = filtro.IdUsuario,
        //        NomeFuncionario = filtro.NomeFuncionario,
        //        CodigoFuncionario = filtro.CodigoFuncionario,
        //        Setor = filtro.Setor,
        //        DataEmissao = filtro.DataEmissao,
        //        Salario = filtro.Salario,
        //        Carteiratrabalho = filtro.Carteiratrabalho,
        //        CarteiraMotorista = filtro.CarteiraMotorista,
        //        Rg = filtro.Rg,
        //        Cpf = filtro.Cpf,
        //        Endereco = filtro.Endereco,
        //        Bairro = filtro.Bairro,
        //        Cidade = filtro.Cidade,
        //        Ud = filtro.Ud,
        //        Fone1 = filtro.Fone1,
        //        Fone2 = filtro.Fone2,
        //        //Status = filtro.Status,
        //        Senha = filtro.Senha,
        //        Perfil = filtro.Perfil,
        //        Email = filtro.Email,
        //        //Sexo = filtro.Sexo,

        //    };

        //    //model.DdlOperadora = OperadoraLista();
        //    //model.DdlTipoPessoa = TipoPessoaLista();
        //    //model.DdlUFLista = UFLista(this._ufApp.ListarTodos());
        //    //model.DdlPerfil = PerfilLista(this._perfilApp.ListarTodos());
        //    //model.DdlTipoEnderecoLista = TipoEnderecoLista();
        //    //model.DdlTipoTelefoneLista = TipoTelefoneLista();

        //    return View(model);
        //}

        //public ActionResult Excluir(int id)
        //{
        //    try
        //    {
        //        this.usuarioApp.Excluir(id);
        //        TempData["msgsucesso"] = "Registro excluido com sucesso!";

        //        return RedirectToAction("create", "usuario");

        //    }

        //    catch (Exception exception)
        //    {
        //        TempData["msgerror"] = exception.Message.ToString();
        //        return RedirectToAction("index", "usuario");
        //    }
        //}
        public ActionResult Download()
        {
            var dataTable = this.usuarioApp.Relatorio();
            var fileResult = ExportFileHelper.ToExcel("usuario", "~/content/arquivo/relatorio/", ".xls", dataTable);

            return File(fileResult, "application/vnd.ms-excel");
        }

    }
}