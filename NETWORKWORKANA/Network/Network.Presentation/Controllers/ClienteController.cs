using Network.Dommain;
using Network.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Network.Presentation.Controllers
{
    public class ClienteController : BaseController
    {
        private readonly Network.Application.ClienteApplication appCliente;

        public ClienteController()
        {
            this.appCliente = new Application.ClienteApplication();
        }
        // GET: Cliente
        public ActionResult Index()
        {
            var model = new List<ClienteModels>();

            foreach (var item in this.appCliente.ListarTodos())
            {
                var objeto = new ClienteModels
                {
                    IdCliente = item.IdCliente,
                    NomeRazaoSocial = item.NomeRazaoSocial,
                    ApelidoNomeFantasia = item.ApelidoNomeFantasia,
                    Contato = item.Contato,
                    DataCadastro = item.DataCadastro,
                    Telefone1 = item.Telefone1,
                    Telefone2 = item.Telefone2,
                    Fax = item.Fax,
                    Cnpj = item.Cnpj,
                    Cpf = item.Cpf,
                    IncricaoEstadualRg = item.IncricaoEstadualRg,
                    Endereco1 = item.Endereco1,
                    Numero1 = item.Numero1,
                    Cidade1 = item.Cidade1,
                    Uf1 = item.Uf1,
                    Cep1 = item.Cep1,
                    Endereco2 = item.Endereco2,
                    Numero2 = item.Numero2,
                    Cidade2 = item.Cidade2,
                    Uf2 = item.Uf2,
                    Cep2 = item.Cep2,
                    Referencia1 = item.Referencia1,
                    TelefoneReferencia1 = item.TelefoneReferencia1,
                    EmailReferencia1 = item.EmailReferencia1,
                    DataNascimento = item.DataNascimento,
                    Referencia2 = item.Referencia2,
                    TelefoneReferncia2 = item.TelefoneReferncia2,
                    Renda = item.Renda,
                    Credito = item.Credito,
                    CodMunicipio = item.CodMunicipio,
                    Spc = item.Spc,
                    Serasa = item.Serasa,
                    TeleCheque = item.TeleCheque,
                    Bloqueado = item.Bloqueado,
                    Classificacao = item.Classificacao,
                    TipoRegiao = item.TipoRegiao,
                    ProfissaoRamo = item.ProfissaoRamo,
                    VendedorAtendente = item.VendedorAtendente,
                    Trasportadora = item.Trasportadora,
                    Observacao = item.Observacao
                };
                model.Add(objeto);
            }
            return View(model);
        }

        public ActionResult Create()
        {
            var model = new ClienteModels();

            return View(model);
        }
        [HttpPost]
        public ActionResult Create(ClienteModels model)
        {


            try
            {

                var dto = new Networkcliente
                {
                    IdCliente = model.IdCliente,
                    NomeRazaoSocial = model.NomeRazaoSocial,
                    ApelidoNomeFantasia = model.ApelidoNomeFantasia,
                    Contato = model.Contato,
                    DataCadastro = DateTime.Now,
                    Telefone1 = model.Telefone1,
                    Telefone2 = model.Telefone2,
                    Fax = model.Fax,
                    Cnpj = model.Cnpj,
                    Cpf = model.Cpf,
                    IncricaoEstadualRg = model.IncricaoEstadualRg,
                    Endereco1 = model.Endereco1,
                    Numero1 = model.Numero1,
                    Cidade1 = model.Cidade1,
                    Uf1 = model.Uf1,
                    Cep1 = model.Cep1,
                    Endereco2 = model.Endereco2,
                    Numero2 = model.Numero2,
                    Cidade2 = model.Cidade2,
                    Uf2 = model.Uf2,
                    Cep2 = model.Cep2,
                    Referencia1 = model.Referencia1,
                    TelefoneReferencia1 = model.TelefoneReferencia1,
                    EmailReferencia1 = model.EmailReferencia1,
                    DataNascimento = DateTime.Now,
                    Referencia2 = model.Referencia2,
                    TelefoneReferncia2 = model.TelefoneReferncia2,
                    Renda = model.Renda,
                    Credito = model.Credito,
                    CodMunicipio = model.CodMunicipio,
                    //Spc = model.Spc,
                    //Serasa = model.Serasa,
                    //TeleCheque = model.TeleCheque,
                    //Bloqueado = model.Bloqueado,
                    //Classificacao = model.Classificacao,
                    TipoRegiao = model.TipoRegiao,
                    ProfissaoRamo = model.ProfissaoRamo,
                    VendedorAtendente = model.VendedorAtendente,
                    Trasportadora = model.Trasportadora,
                    Observacao = model.Observacao,
                };

                //model.DdlSexo = SexoLista();

                if (ModelState.IsValid)
                {
                    this.appCliente.Salvar(dto);
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
    }
}