using Network.Dommain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Network.Infra.Models.Mapping
{
    public class networkprodutoMap : EntityTypeConfiguration<networkproduto>
    {
        public networkprodutoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdProduto);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(200);

            this.Property(t => t.NomeProduto)
                .HasMaxLength(100);

            this.Property(t => t.Classificacao)
                .HasMaxLength(200);

            this.Property(t => t.DescTipoProduto)
                .HasMaxLength(100);

            this.Property(t => t.Tamanho)
                .HasMaxLength(100);

            this.Property(t => t.Peso)
                .HasMaxLength(100);

            this.Property(t => t.Forncedor)
                .HasMaxLength(100);

            this.Property(t => t.CnpjFornecedor)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("networkprodutos");
            this.Property(t => t.IdProduto).HasColumnName("IdProduto");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.NomeProduto).HasColumnName("NomeProduto");
            this.Property(t => t.Classificacao).HasColumnName("Classificacao");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.TipoProduto).HasColumnName("TipoProduto");
            this.Property(t => t.CnpjFornecedor).HasColumnName("DescTipoProduto");
            this.Property(t => t.CnpjFornecedor).HasColumnName("CnpjFornecedor");
            this.Property(t => t.Forncedor).HasColumnName("Forncedor");
            this.Property(t => t.Tamanho).HasColumnName("Tamanho");
            this.Property(t => t.Peso).HasColumnName("Peso");
            this.Property(t => t.ValorASerPagoProdutor).HasColumnName("ValorASerPagoProdutor");
            this.Property(t => t.ValorASerCobradoProdutor).HasColumnName("ValorASerCobradoProdutor");
        }
    }
}
