using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TesteODS.Models.Mapping
{
    public class networkcontasareceberMap : EntityTypeConfiguration<networkcontasareceber>
    {
        public networkcontasareceberMap()
        {
            // Primary Key
            this.HasKey(t => t.IdContasAReceber);

            // Properties
            this.Property(t => t.Fornecedor)
                .HasMaxLength(100);

            this.Property(t => t.Pagador)
                .HasMaxLength(100);

            this.Property(t => t.Recebedor)
                .HasMaxLength(100);

            this.Property(t => t.Identificacao)
                .HasMaxLength(5000);

            // Table & Column Mappings
            this.ToTable("networkcontasareceber");
            this.Property(t => t.IdContasAReceber).HasColumnName("IdContasAReceber");
            this.Property(t => t.Data).HasColumnName("Data");
            this.Property(t => t.Fornecedor).HasColumnName("Fornecedor");
            this.Property(t => t.Pagador).HasColumnName("Pagador");
            this.Property(t => t.Recebedor).HasColumnName("Recebedor");
            this.Property(t => t.Identificacao).HasColumnName("Identificacao");
            this.Property(t => t.Vencimento).HasColumnName("Vencimento");
            this.Property(t => t.valor).HasColumnName("valor");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
