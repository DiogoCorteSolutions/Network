using Network.Dommain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Infra.Models.Mapping
{
    public class networktipoMap : EntityTypeConfiguration<networktipo>
    {
        public networktipoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdTipo);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(100);

            this.Property(t => t.Descricao)
                .HasMaxLength(100);

            this.Property(t => t.DescTipo)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("networktipo");
            this.Property(t => t.IdTipo).HasColumnName("IdTipo");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.DescTipo).HasColumnName("DescTipo");
        }
    }
}
