using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Network.Presentation.Models
{
    public class FornecedorModels : BaseModels
    {
        public int IdFornecedor { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public Nullable<System.DateTime> DataCadastro { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string CnpjCpf { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string IncricaoEstadual { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string LinhaProdutos { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string SiteUrl { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string TrasportadoraUltilizada { get; set; }
        public string Codigo { get; set; }
        public string Observacao { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
    }
}