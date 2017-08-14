using System;
using System.Collections.Generic;

namespace Network.Dommain
{
    public partial class networkcomposicao
    {
        public int IdComposicao { get; set; }
        public string Descricao { get; set; }
        public string NomeComposicao { get; set; }
        public string Classificacao { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> Quantiomposicao { get; set; }
        public string DescTipoComposicao { get; set; }
        public string Tamanho { get; set; }
        public string Peso { get; set; }
        public Nullable<decimal> ValorASerPagoProdutor { get; set; }
        public Nullable<decimal> ValorASerCobradoProdutor { get; set; }
    }
}
