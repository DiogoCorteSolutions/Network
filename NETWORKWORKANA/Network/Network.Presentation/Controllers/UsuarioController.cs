using Network.Dommain;
using Network.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Network.Presentation.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Application.UsuarioApplication usuarioApp;

        // GET: Cliente
        public UsuarioController()
        {
            this.usuarioApp = new Application.UsuarioApplication();
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
                    DataEmaissao = item.DataEmaissao,
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
                    Status = item.Status,
                    Senha = item.Senha,
                    Perfil = item.Perfil,
                    Email = item.Email,
                    Sexo = item.Sexo,

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
                    DataEmaissao = Convert.ToDateTime(model.DataEmaissao),
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


        //public ActionResult Download()
        //{
        //    var dataTable = this.Download .Relatorio();
        //    var fileResult = ExportFileHelper.ToExcel("cliente", "~/content/arquivo/relatorio/", ".xls", dataTable);

        //    return File(fileResult, "application/vnd.ms-excel");
        //}

    }
}