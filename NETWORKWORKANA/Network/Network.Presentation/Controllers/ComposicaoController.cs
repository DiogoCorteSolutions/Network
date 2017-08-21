using Network.Dommain;
using Network.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Network.Presentation.Controllers
{
    public class ComposicaoController : BaseController
    {
        private readonly Network.Application.ComposicaoApplication appComposicao;

        public ComposicaoController()
        {
            this.appComposicao = new Application.ComposicaoApplication();
        }
        // GET: Composicao
        public ActionResult Index()
        {
            var model = new List<ComposicaoModels>();

            foreach (var item in this.appComposicao.ListarTodos().ToList().Where(x => x.Status == "CADASTRADO"))
            {
                var objeto = new ComposicaoModels
                {
                    IdComposicao = item.IdComposicao,
                    Descricao = item.Descricao,
                    NomeComposicao = item.NomeComposicao,
                    Classificacao = item.Classificacao,
                    Status = item.Status,
                    Quantiomposicao = item.Quantiomposicao,
                    DescTipoComposicao = item.DescTipoComposicao,
                    Tamanho = item.Tamanho,
                    Peso = item.Peso,
                    ValorASerPagoProdutor = item.ValorASerPagoProdutor,
                    ValorASerCobradoProdutor = item.ValorASerCobradoProdutor,
                };
                model.Add(objeto);
            }
            return View(model);
        }

        public ActionResult Create()
        {
            var model = new ComposicaoModels();

            return View(model);
        }
        [HttpPost]
        public ActionResult Create(ComposicaoModels model)
        {
            try
            {
                var dto = new networkcomposicao
                {
                    IdComposicao = model.IdComposicao,
                    Descricao = model.Descricao,
                    NomeComposicao = model.NomeComposicao,
                    //Classificacao = model.Classificacao,
                    Status = "CADASTRADO",
                    //Quantiomposicao = model.Quantiomposicao,
                    DescTipoComposicao = model.DescTipoComposicao,
                    Tamanho = model.Tamanho,
                    Peso = model.Peso,
                    ValorASerPagoProdutor = model.ValorASerPagoProdutor,
                    ValorASerCobradoProdutor = model.ValorASerCobradoProdutor,
                };

                if (ModelState.IsValid)
                {
                    this.appComposicao.Salvar(dto);
                    TempData["msgsucesso"] = "Registro salvo com sucesso";

                }

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
            var filtro = this.appComposicao.ListarPorId(id);





            var model = new ComposicaoModels
            {
                IdComposicao = filtro.IdComposicao,
                Descricao = filtro.Descricao,
                NomeComposicao = filtro.NomeComposicao,
                Classificacao = filtro.Classificacao,
                //Status = item.Status,
                Quantiomposicao = filtro.Quantiomposicao,
                DescTipoComposicao = filtro.DescTipoComposicao,
                Tamanho = filtro.Tamanho,
                Peso = filtro.Peso,
                ValorASerPagoProdutor = filtro.ValorASerPagoProdutor,
                ValorASerCobradoProdutor = filtro.ValorASerCobradoProdutor,
            };

            model.DdSexo = SexoLista();


            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(ComposicaoModels model)
        {

            model.DdSexo = SexoLista();

            try
            {
                var filtro = this.appComposicao.ListarPorId(model.IdComposicao);


                filtro.IdComposicao = model.IdComposicao;
                filtro.Descricao = model.Descricao;
                filtro.NomeComposicao = model.NomeComposicao;
                filtro.Classificacao = model.Classificacao;
                filtro.Status = model.Status;
                filtro.Quantiomposicao = model.Quantiomposicao;
                filtro.DescTipoComposicao = model.DescTipoComposicao;
                filtro.Tamanho = model.Tamanho;
                filtro.Peso = model.Peso;
                filtro.ValorASerPagoProdutor = model.ValorASerPagoProdutor;
                filtro.ValorASerCobradoProdutor = model.ValorASerCobradoProdutor;



                if (ModelState.IsValid)
                {
                    this.appComposicao.Atualizar(filtro);

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
                this.appComposicao.Excluir(id);
                TempData["msgsucesso"] = "Registro excluido com sucesso!";

                return RedirectToAction("create", "composicao");

            }

            catch (Exception exception)
            {
                TempData["msgerror"] = exception.Message.ToString();
                return RedirectToAction("create", "composicao");
            }
        }


        protected IEnumerable<SelectListItem> SexoLista()
        {
            var retorno = new List<SelectListItem>();

            retorno.Add(new SelectListItem { Selected = true, Text = "Selecione", Value = "" });
            retorno.Add(new SelectListItem { Text = "CADASTRADO", Value = "CADASTRADO" });
            retorno.Add(new SelectListItem { Text = "VENDIDO", Value = "VENDIDO" });

            return retorno;
        }
    }
}