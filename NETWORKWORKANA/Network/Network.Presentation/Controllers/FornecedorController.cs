using Network.Dommain;
using Network.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Network.Presentation.Controllers
{
    public class FornecedorController : Controller
    {

        private readonly Network.Application.FornecedorApplication fornecedorApp;

        public FornecedorController()
        {
            this.fornecedorApp = new Application.FornecedorApplication();
        }

        // GET: Fornecedor
        public ActionResult Index()
        {
            var model = new List<FornecedorModels>();

            foreach (var item in this.fornecedorApp.ListarTodos())
            {
                var objeto = new FornecedorModels
                {

                    IdFornecedor = item.IdFornecedor,
                    RazaoSocial = item.RazaoSocial,
                    NomeFantasia = item.NomeFantasia,
                    DataCadastro = item.DataCadastro,
                    Telefone1 = item.Telefone1,
                    Telefone2 = item.Telefone2,
                    CnpjCpf = item.CnpjCpf,
                    Cpf = item.Cpf,
                    Cnpj = item.Cnpj,
                    IncricaoEstadual = item.IncricaoEstadual,
                    Endereco = item.Endereco,
                    Bairro = item.Bairro,
                    LinhaProdutos = item.LinhaProdutos,
                    Cidade = item.Cidade,
                    Uf = item.Uf,
                    Cep = item.Cep,
                    SiteUrl = item.SiteUrl,
                    Banco = item.Banco,
                    Agencia = item.Agencia,
                    Conta = item.Conta,
                    TrasportadoraUltilizada = item.TrasportadoraUltilizada,
                    Codigo = item.Codigo,
                    Observacao = item.Observacao,
                    Contato = item.Contato,
                    Email = item.Email,
                    Fax = item.Fax,


                };
                model.Add(objeto);
            }
            return View(model);
        }
        public ActionResult Create()
        {
            var model = new FornecedorModels();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(FornecedorModels model)
        {


            try
            {

                var dto = new networkfornecedore
                {
                    IdFornecedor = model.IdFornecedor,
                    RazaoSocial = model.RazaoSocial,
                    NomeFantasia = model.NomeFantasia,
                    DataCadastro = DateTime.Now,
                    Telefone1 = model.Telefone1,
                    Telefone2 = model.Telefone2,
                    CnpjCpf = model.CnpjCpf,
                    //Cpf = model.Cpf,
                    //Cnpj = model.Cnpj,
                    IncricaoEstadual = model.IncricaoEstadual,
                    Endereco = model.Endereco,
                    Bairro = model.Bairro,
                    LinhaProdutos = model.LinhaProdutos,
                    Cidade = model.Cidade,
                    Uf = model.Uf,
                    Cep = model.Cep,
                    SiteUrl = model.SiteUrl,
                    Banco = model.Banco,
                    Agencia = model.Agencia,
                    Conta = model.Conta,
                    TrasportadoraUltilizada = model.TrasportadoraUltilizada,
                    Codigo = model.Codigo,
                    Observacao = model.Observacao,
                    Contato = model.Contato,
                    Email = model.Email,
                    Fax = model.Fax,
                };


                if (ModelState.IsValid)
                {
                    this.fornecedorApp.Salvar(dto);
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

        public ActionResult Edit(int id)
        {
            var filtro = this.fornecedorApp.ListarPorId(id);

            var model = new FornecedorModels
            {
                IdFornecedor = filtro.IdFornecedor,
                RazaoSocial = filtro.RazaoSocial,
                NomeFantasia = filtro.NomeFantasia,
                Telefone1 = filtro.Telefone1,
                Telefone2 = filtro.Telefone2,
                CnpjCpf = filtro.CnpjCpf,
                Cpf = filtro.Cpf,
                Cnpj = filtro.Cnpj,
                IncricaoEstadual = filtro.IncricaoEstadual,
                Endereco = filtro.Endereco,
                Bairro = filtro.Bairro,
                LinhaProdutos = filtro.LinhaProdutos,
                Cidade = filtro.Cidade,
                Uf = filtro.Uf,
                Cep = filtro.Cep,
                SiteUrl = filtro.SiteUrl,
                Banco = filtro.Banco,
                Agencia = filtro.Agencia,
                Conta = filtro.Conta,
                TrasportadoraUltilizada = filtro.TrasportadoraUltilizada,
                Codigo = filtro.Codigo,
                Observacao = filtro.Observacao,
                Contato = filtro.Contato,
                Email = filtro.Email,
                Fax = filtro.Fax,

            };

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(FornecedorModels model)
        {
            try
            {
                var filtro = this.fornecedorApp.ListarPorId(model.IdFornecedor);

                filtro.IdFornecedor = model.IdFornecedor;
                filtro.RazaoSocial = model.RazaoSocial;
                filtro.NomeFantasia = model.NomeFantasia;
                filtro.Telefone1 = model.Telefone1;
                filtro.Telefone2 = model.Telefone2;
                filtro.CnpjCpf = model.CnpjCpf;
                filtro.Cpf = model.Cpf;
                filtro.Cnpj = model.Cnpj;
                filtro.IncricaoEstadual = model.IncricaoEstadual;
                filtro.Endereco = model.Endereco;
                filtro.Bairro = model.Bairro;
                filtro.LinhaProdutos = model.LinhaProdutos;
                filtro.Cidade = model.Cidade;
                filtro.Uf = model.Uf;
                filtro.Cep = model.Cep;
                filtro.SiteUrl = model.SiteUrl;
                filtro.Banco = model.Banco;
                filtro.Agencia = model.Agencia;
                filtro.Conta = model.Conta;
                filtro.TrasportadoraUltilizada = model.TrasportadoraUltilizada;
                filtro.Codigo = model.Codigo;
                filtro.Observacao = model.Observacao;
                filtro.Contato = model.Contato;
                filtro.Email = model.Email;
                filtro.Fax = model.Fax;


                if (ModelState.IsValid)
                {
                    this.fornecedorApp.Atualizar(filtro);

                    TempData["msgsucesso"] = "Registro atualizado com sucesso";
                }

                return View(model);
            }
            catch (Exception exception)
            {
                TempData["msgerror"] = exception.Message.ToString();

                return View(model);
            }
        }

        public ActionResult Excluir(int id)
        {
            try
            {
                this.fornecedorApp.Excluir(id);
                TempData["msgsucesso"] = "Registro excluido com sucesso!";

                return RedirectToAction("create", "fornecedor");

            }

            catch (Exception exception)
            {
                TempData["msgerror"] = exception.Message.ToString();
                return RedirectToAction("create", "fornecedor");
            }
        }
    }
}