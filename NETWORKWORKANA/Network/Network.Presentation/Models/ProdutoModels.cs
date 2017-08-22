using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Network.Presentation.Models
{
    public class ProdutoModels : BaseModels
    {
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public string NomeProduto { get; set; }
        public string Classificacao { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<int> TipoProduto { get; set; }
        public string DescTipoProduto { get; set; }
        public string Tamanho { get; set; }
        public string Peso { get; set; }
        public string Forncedor { get; set; }
        public string CnpjFornecedor { get; set; }
        public Nullable<decimal> ValorASerPagoProdutor { get; set; }
        public Nullable<decimal> ValorASerCobradoProdutor { get; set; }        
        public IEnumerable<SelectListItem> DdPerfil { get; set; }
    }
}