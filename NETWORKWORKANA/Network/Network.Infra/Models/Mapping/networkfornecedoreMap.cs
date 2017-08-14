using Network.Dommain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Network.Infra.Models.Mapping
{
    public class networkfornecedoreMap : EntityTypeConfiguration<networkfornecedore>
    {
        public networkfornecedoreMap()
        {
            // Primary Key
            this.HasKey(t => t.IdFornecedor);

            // Properties
            this.Property(t => t.RazaoSocial)
                .HasMaxLength(500);

            this.Property(t => t.NomeFantasia)
                .HasMaxLength(500);

            this.Property(t => t.Telefone1)
                .HasMaxLength(100);

            this.Property(t => t.Telefone2)
                .HasMaxLength(100);

            this.Property(t => t.CnpjCpf)
                .HasMaxLength(100);

            this.Property(t => t.Cpf)
                .HasMaxLength(100);

            this.Property(t => t.Cnpj)
                .HasMaxLength(100);

            this.Property(t => t.IncricaoEstadual)
                .HasMaxLength(100);

            this.Property(t => t.Endereco)
                .HasMaxLength(300);

            this.Property(t => t.Bairro)
                .HasMaxLength(300);

            this.Property(t => t.LinhaProdutos)
                .HasMaxLength(100);

            this.Property(t => t.Cidade)
                .HasMaxLength(300);

            this.Property(t => t.Uf)
                .HasMaxLength(100);

            this.Property(t => t.Cep)
                .HasMaxLength(100);

            this.Property(t => t.SiteUrl)
                .HasMaxLength(300);

            this.Property(t => t.Banco)
                .HasMaxLength(100);

            this.Property(t => t.Agencia)
                .HasMaxLength(100);

            this.Property(t => t.Conta)
                .HasMaxLength(100);

            this.Property(t => t.TrasportadoraUltilizada)
                .HasMaxLength(100);

            this.Property(t => t.Codigo)
                .HasMaxLength(100);

            this.Property(t => t.Observacao)
                .HasMaxLength(6000);

            this.Property(t => t.Contato)
                .HasMaxLength(300);

            this.Property(t => t.Email)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("networkfornecedores");
            this.Property(t => t.IdFornecedor).HasColumnName("IdFornecedor");
            this.Property(t => t.RazaoSocial).HasColumnName("RazaoSocial");
            this.Property(t => t.NomeFantasia).HasColumnName("NomeFantasia");
            this.Property(t => t.DataCadastro).HasColumnName("DataCadastro");
            this.Property(t => t.Telefone1).HasColumnName("Telefone1");
            this.Property(t => t.Telefone2).HasColumnName("Telefone2");
            this.Property(t => t.CnpjCpf).HasColumnName("CnpjCpf");
            this.Property(t => t.Cpf).HasColumnName("Cpf");
            this.Property(t => t.Cnpj).HasColumnName("Cnpj");
            this.Property(t => t.IncricaoEstadual).HasColumnName("IncricaoEstadual");
            this.Property(t => t.Endereco).HasColumnName("Endereco");
            this.Property(t => t.Bairro).HasColumnName("Bairro");
            this.Property(t => t.LinhaProdutos).HasColumnName("LinhaProdutos");
            this.Property(t => t.Cidade).HasColumnName("Cidade");
            this.Property(t => t.Uf).HasColumnName("Uf");
            this.Property(t => t.Cep).HasColumnName("Cep");
            this.Property(t => t.SiteUrl).HasColumnName("SiteUrl");
            this.Property(t => t.Banco).HasColumnName("Banco");
            this.Property(t => t.Agencia).HasColumnName("Agencia");
            this.Property(t => t.Conta).HasColumnName("Conta");
            this.Property(t => t.TrasportadoraUltilizada).HasColumnName("TrasportadoraUltilizada");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.Observacao).HasColumnName("Observacao");
            this.Property(t => t.Contato).HasColumnName("Contato");
            this.Property(t => t.Email).HasColumnName("Email");
        }
    }
}
