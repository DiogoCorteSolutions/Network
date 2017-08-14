using System;
using System.Collections.Generic;

namespace Network.Dommain
{
    public partial class networkcontasareceber
    {
        public int IdContasAReceber { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Fornecedor { get; set; }
        public string Pagador { get; set; }
        public string Recebedor { get; set; }
        public string Identificacao { get; set; }
        public Nullable<System.DateTime> Vencimento { get; set; }
        public Nullable<decimal> valor { get; set; }
        public bool Status { get; set; }
    }
}
