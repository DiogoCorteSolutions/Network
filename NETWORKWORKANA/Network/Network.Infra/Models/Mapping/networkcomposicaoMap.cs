using Network.Dommain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Network.Infra.Models.Mapping
{
    public class networkcomposicaoMap : EntityTypeConfiguration<networkcomposicao>
    {
        public networkcomposicaoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdComposicao);

            // Properties
            this.Property(t => t.Descricao)
                .HasMaxLength(200);

            this.Property(t => t.NomeComposicao)
                .HasMaxLength(100);

            this.Property(t => t.Classificacao)
                .HasMaxLength(200);

            this.Property(t => t.DescTipoComposicao)
                .HasMaxLength(100);

            this.Property(t => t.Tamanho)
                .HasMaxLength(100);

            this.Property(t => t.Peso)
                .HasMaxLength(100);

            this.Property(t => t.Status)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("networkcomposicao");
            this.Property(t => t.IdComposicao).HasColumnName("IdComposicao");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.NomeComposicao).HasColumnName("NomeComposicao");
            this.Property(t => t.Classificacao).HasColumnName("Classificacao");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Quantiomposicao).HasColumnName("Quantiomposicao");
            this.Property(t => t.DescTipoComposicao).HasColumnName("DescTipoComposicao");
            this.Property(t => t.Tamanho).HasColumnName("Tamanho");
            this.Property(t => t.Peso).HasColumnName("Peso");
            this.Property(t => t.ValorASerPagoProdutor).HasColumnName("ValorASerPagoProdutor");
            this.Property(t => t.ValorASerCobradoProdutor).HasColumnName("ValorASerCobradoProdutor");
        }
    }
}
