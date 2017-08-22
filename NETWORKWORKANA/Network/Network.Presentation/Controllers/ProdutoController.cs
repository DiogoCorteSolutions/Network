using Network.Dommain;
using Network.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Network.Presentation.Controllers
{
    public class ProdutoController : BaseController
    {

        private readonly Network.Application.FornecedorApplication appForecedor;
        private readonly Network.Application.ProdutoApplication appProduto;

        public ProdutoController()
        {
            this.appForecedor = new Application.FornecedorApplication();
            this.appProduto = new Application.ProdutoApplication();
        }
        // GET: Produto
        public ActionResult Index(int id)
        {

            var filtro = this.appForecedor.ListarPorId(id);





            var model = new FornecedorModels
            {
                //IdComposicao = filtro.IdComposicao,
                //Descricao = filtro.Descricao,
                //NomeComposicao = filtro.NomeComposicao,
                //Classificacao = filtro.Classificacao,
                ////Status = item.Status,
                //Quantiomposicao = filtro.Quantiomposicao,
                //DescTipoComposicao = filtro.DescTipoComposicao,
                //Tamanho = filtro.Tamanho,
                //Peso = filtro.Peso,
                //ValorASerPagoProdutor = filtro.ValorASerPagoProdutor,
                //ValorASerCobradoProdutor = filtro.ValorASerCobradoProdutor,
            };

            model.DdlListaPerfil = PerfilListaAll(this.appForecedor.ListarTodos().ToList().Where(x => x.LinhaProdutos.Equals("Tomate")));


            return View(model);
        }

   


        //private IEnumerable<SelectListItem> FornecedorLista(IEnumerable<networkfornecedore> lista)
        //{
        //    var retorno = new List<SelectListItem>();
        //    retorno.Equals(new SelectListItem { Selected = true, Text = "Selecione", Value = "" });

        //    retorno.AddRange(lista.Where(x => x.LinhaProdutos.Contains("Tomate")).Select(item => new SelectListItem
        //    {
        //        Text = item.NomeFantasia,
        //        Value = item.IdFornecedor.ToString()

        //    }).ToList());

        //    return retorno;
        //}

        protected IEnumerable<SelectListItem> PerfilListaAll(IEnumerable<networkfornecedore> lista)
        {
            var retorno = new List<SelectListItem>();
            retorno.Equals(new SelectListItem { Selected = true, Text = "Selecione", Value = "" });

            retorno.AddRange(lista.Select(item => new SelectListItem
            {
                Text = item.RazaoSocial,
                Value = item.IdFornecedor.ToString()

            }).ToList());

            return retorno;

        }

    }
}