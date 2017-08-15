using System;
using System.Collections.Generic;

namespace Network.Dommain
{
    public partial class Networkcliente
    {
        public int IdCliente { get; set; }
        public string NomeRazaoSocial { get; set; }
        public string ApelidoNomeFantasia { get; set; }
        public string Contato { get; set; }
        public Nullable<System.DateTime> DataCadastro { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Fax { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public string IncricaoEstadualRg { get; set; }
        public string Endereco1 { get; set; }
        public string Numero1 { get; set; }
        public string Cidade1 { get; set; }
        public string Uf1 { get; set; }
        public string Cep1 { get; set; }
        public string Endereco2 { get; set; }
        public string Numero2 { get; set; }
        public string Cidade2 { get; set; }
        public string Uf2 { get; set; }
        public string Cep2 { get; set; }
        public string Referencia1 { get; set; }
        public string TelefoneReferencia1 { get; set; }
        public string EmailReferencia1 { get; set; }
        public string DataNascimento { get; set; }
        public string Referencia2 { get; set; }
        public string TelefoneReferncia2 { get; set; }
        public Nullable<decimal> Renda { get; set; }
        public Nullable<decimal> Credito { get; set; }
        public string CodMunicipio { get; set; }
        public Nullable<bool> Spc { get; set; }
        public Nullable<bool> Serasa { get; set; }
        public Nullable<bool> TeleCheque { get; set; }
        public Nullable<bool> Bloqueado { get; set; }
        public Nullable<bool> Classificacao { get; set; }
        public string TipoRegiao { get; set; }
        public string ProfissaoRamo { get; set; }
        public string VendedorAtendente { get; set; }
        public string Trasportadora { get; set; }
        public string Observacao { get; set; }
        public Nullable<bool> Sexo { get; set; }
    }
}
