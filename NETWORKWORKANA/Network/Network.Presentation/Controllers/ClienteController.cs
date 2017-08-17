using Network.Dommain;
using Network.Presentation.InfraStructre;
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
                    Observacao = item.Observacao,
                    Bairro1 = item.Bairro1,
                    Bairro2 = item.Bairro2,
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
            if (this.appCliente.Existe(model.Cpf))
            {
                TempData["msgsucesso"] = "CPF já cadastrado.";
                return View(model);
            }

            if (custom.ValidationCPF.IsCpf(model.Cpf))
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
                        //Cpf = model.Cpf,
                        Cpf = StringHelper.FormatarCpf(model.Cpf),
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
                        DataNascimento = model.DataNascimento,
                        Referencia2 = model.Referencia2,
                        TelefoneReferncia2 = model.TelefoneReferncia2,
                        Renda = model.Renda,
                        Credito = model.Credito,
                        CodMunicipio = model.CodMunicipio,
                        //Spc = false,
                        //Serasa = false,
                        //TeleCheque = false,
                        //Bloqueado = false,
                        Classificacao = model.Classificacao,
                        TipoRegiao = model.TipoRegiao,
                        ProfissaoRamo = model.ProfissaoRamo,
                        VendedorAtendente = model.VendedorAtendente,
                        Trasportadora = model.Trasportadora,
                        Observacao = model.Observacao,
                        Bairro1 = model.Bairro1,
                        Bairro2 = model.Bairro2,
                    };



                    if (ModelState.IsValid)
                    {
                        this.appCliente.Salvar(dto);
                        TempData["msgsucesso"] = "Registro salvo com sucesso";

                    }


                }
                catch (Exception exception)
                {
                    TempData["msgerror"] = exception.Message.ToString();
                    return View(model);
                }
            }
            else
            {

                TempData["msgerror"] = "Cpf invalido";
            }

            return RedirectToAction("create");



        }


        //public ActionResult Create(ClienteModels model)
        //{
        //    if (this.appCliente.Existe(model.Cpf))
        //    {
        //        TempData["msgsucesso"] = "CPF já Cadastrado";
        //        return View(model);

        //    }

        //    try
        //    {

        //        var dto = new Networkcliente
        //        {
        //            IdCliente = model.IdCliente,
        //            NomeRazaoSocial = model.NomeRazaoSocial,
        //            ApelidoNomeFantasia = model.ApelidoNomeFantasia,
        //            Contato = model.Contato,
        //            DataCadastro = DateTime.Now,
        //            Telefone1 = model.Telefone1,
        //            Telefone2 = model.Telefone2,
        //            Fax = model.Fax,
        //            Cnpj = model.Cnpj,
        //            //Cpf = model.Cpf,
        //            Cpf = StringHelper.FormatarCpf(model.Cpf),
        //            IncricaoEstadualRg = model.IncricaoEstadualRg,
        //            Endereco1 = model.Endereco1,
        //            Numero1 = model.Numero1,
        //            Cidade1 = model.Cidade1,
        //            Uf1 = model.Uf1,
        //            Cep1 = model.Cep1,
        //            Endereco2 = model.Endereco2,
        //            Numero2 = model.Numero2,
        //            Cidade2 = model.Cidade2,
        //            Uf2 = model.Uf2,
        //            Cep2 = model.Cep2,
        //            Referencia1 = model.Referencia1,
        //            TelefoneReferencia1 = model.TelefoneReferencia1,
        //            EmailReferencia1 = model.EmailReferencia1,
        //            DataNascimento = model.DataNascimento,
        //            Referencia2 = model.Referencia2,
        //            TelefoneReferncia2 = model.TelefoneReferncia2,
        //            Renda = model.Renda,
        //            Credito = model.Credito,
        //            CodMunicipio = model.CodMunicipio,
        //            //Spc = false,
        //            //Serasa = false,
        //            //TeleCheque = false,
        //            //Bloqueado = false,
        //            Classificacao = model.Classificacao,
        //            TipoRegiao = model.TipoRegiao,
        //            ProfissaoRamo = model.ProfissaoRamo,
        //            VendedorAtendente = model.VendedorAtendente,
        //            Trasportadora = model.Trasportadora,
        //            Observacao = model.Observacao,
        //            Bairro1 = model.Bairro1,
        //            Bairro2 = model.Bairro2,
        //        };

        //        //model.DdlSexo = SexoLista();

        //        if (ModelState.IsValid)
        //        {
        //            this.appCliente.Salvar(dto);
        //            TempData["msgsucesso"] = "Registro salvo com sucesso";
        //        }

        //        //model.Nome = string.Empty;
        //        //model.Descricao = string.Empty;
        //        //model.ISBN = string.Empty;
        //        //model.Autor = string.Empty;
        //        //model.Editora = string.Empty;
        //        //model.Ativo = false;
        //        //model.Quantidade = 0;

        //        TempData["msgerro"] = "Não foi possivel salvar os dados.";

        //        return RedirectToAction("create");
        //    }
        //    catch (Exception execption)
        //    {
        //        TempData["msgerror"] = execption.Message.ToString();

        //        return View(model);
        //    }
        //}

        public ActionResult Edit(int id)
        {
            var filtro = this.appCliente.ListarPorId(id);

            var idFixo = id;


            var model = new ClienteModels
            {
                IdCliente = filtro.IdCliente,
                NomeRazaoSocial = filtro.NomeRazaoSocial,
                ApelidoNomeFantasia = filtro.ApelidoNomeFantasia,
                Contato = filtro.Contato,
                Telefone1 = filtro.Telefone1,
                Telefone2 = filtro.Telefone2,
                Fax = filtro.Fax,
                Cnpj = filtro.Cnpj,
                Cpf = filtro.Cpf,
                IncricaoEstadualRg = filtro.IncricaoEstadualRg,
                Endereco1 = filtro.Endereco1,
                Numero1 = filtro.Numero1,
                Cidade1 = filtro.Cidade1,
                Uf1 = filtro.Uf1,
                Cep1 = filtro.Cep1,
                Endereco2 = filtro.Endereco2,
                Numero2 = filtro.Numero2,
                Cidade2 = filtro.Cidade2,
                Uf2 = filtro.Uf2,
                Cep2 = filtro.Cep2,
                Referencia1 = filtro.Referencia1,
                TelefoneReferencia1 = filtro.TelefoneReferencia1,
                EmailReferencia1 = filtro.EmailReferencia1,
                DataNascimento = filtro.DataNascimento,
                Referencia2 = filtro.Referencia2,
                TelefoneReferncia2 = filtro.TelefoneReferncia2,
                Renda = filtro.Renda,
                Credito = filtro.Credito,
                CodMunicipio = filtro.CodMunicipio,
                TipoRegiao = filtro.TipoRegiao,
                ProfissaoRamo = filtro.ProfissaoRamo,
                VendedorAtendente = filtro.VendedorAtendente,
                Trasportadora = filtro.Trasportadora,
                Observacao = filtro.Observacao,
                Bairro1 = filtro.Bairro1,
                Bairro2 = filtro.Bairro2,
            };

            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(ClienteModels model)
        {
            try
            {
                var filtro = this.appCliente.ListarPorId(model.IdCliente);


                filtro.IdCliente = model.IdCliente;
                filtro.NomeRazaoSocial = model.NomeRazaoSocial;
                filtro.ApelidoNomeFantasia = model.ApelidoNomeFantasia;
                filtro.Contato = model.Contato;
                filtro.Telefone1 = model.Telefone1;
                filtro.Telefone2 = model.Telefone2;
                filtro.Fax = model.Fax;
                filtro.Cnpj = model.Cnpj;
                filtro.Cpf = model.Cpf;
                filtro.IncricaoEstadualRg = model.IncricaoEstadualRg;
                filtro.Endereco1 = model.Endereco1;
                filtro.Numero1 = model.Numero1;
                filtro.Cidade1 = model.Cidade1;
                filtro.Uf1 = model.Uf1;
                filtro.Cep1 = model.Cep1;
                filtro.Endereco2 = model.Endereco2;
                filtro.Numero2 = model.Numero2;
                filtro.Cidade2 = model.Cidade2;
                filtro.Uf2 = model.Uf2;
                filtro.Cep2 = model.Cep2;
                filtro.Referencia1 = model.Referencia1;
                filtro.TelefoneReferencia1 = model.TelefoneReferencia1;
                filtro.EmailReferencia1 = model.EmailReferencia1;
                filtro.DataNascimento = model.DataNascimento;
                filtro.Referencia2 = model.Referencia2;
                filtro.TelefoneReferncia2 = model.TelefoneReferncia2;
                filtro.Renda = model.Renda;
                filtro.Credito = model.Credito;
                filtro.CodMunicipio = model.CodMunicipio;
                filtro.TipoRegiao = model.TipoRegiao;
                filtro.ProfissaoRamo = model.ProfissaoRamo;
                filtro.VendedorAtendente = model.VendedorAtendente;
                filtro.Trasportadora = model.Trasportadora;
                filtro.Observacao = model.Observacao;
                filtro.Bairro1 = model.Bairro1;
                filtro.Bairro2 = model.Bairro2;



                if (ModelState.IsValid)
                {
                    this.appCliente.Atualizar(filtro);

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

        public ActionResult ClienteExcluir(int id)
        {
            try
            {
                this.appCliente.Excluir(id);
                TempData["msgsucesso"] = "Registro excluido com sucesso!";

                return RedirectToAction("create", "cliente");

            }

            catch (Exception exception)
            {
                TempData["msgerror"] = exception.Message.ToString();
                return RedirectToAction("create", "cliente");
            }
        }

    }
}