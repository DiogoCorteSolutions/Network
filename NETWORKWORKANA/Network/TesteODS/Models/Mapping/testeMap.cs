using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TesteODS.Models.Mapping
{
    public class testeMap : EntityTypeConfiguration<teste>
    {
        public testeMap()
        {
            // Primary Key
            this.HasKey(t => t.IdCliente);

            // Properties
            // Table & Column Mappings
            this.ToTable("teste");
            this.Property(t => t.IdCliente).HasColumnName("IdCliente");
        }
    }
}
