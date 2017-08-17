using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Network.Presentation.Models
{
    public class ComposicaoModels : BaseModels
    {
        public int IdComposicao { get; set; }
        public string Descricao { get; set; }
        public string NomeComposicao { get; set; }
        public string Classificacao { get; set; }
        public string Status { get; set; }
        public Nullable<int> Quantiomposicao { get; set; }
        public string DescTipoComposicao { get; set; }
        public string Tamanho { get; set; }
        public string Peso { get; set; }
        public Nullable<decimal> ValorASerPagoProdutor { get; set; }
        public Nullable<decimal> ValorASerCobradoProdutor { get; set; }



        public IEnumerable<SelectListItem> DdSexo { get; set; }
    }
}