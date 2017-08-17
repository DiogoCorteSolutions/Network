using Network.Dommain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Network.Infra.Models.Mapping
{
    public class networkperfilMap : EntityTypeConfiguration<networkperfil>
    {
        public networkperfilMap()
        {
            // Primary Key
            this.HasKey(t => t.IdPerfil);

            // Properties
            this.Property(t => t.Perfil)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("networkperfil");
            this.Property(t => t.IdPerfil).HasColumnName("IdPerfil");
            this.Property(t => t.Perfil).HasColumnName("Perfil");
        }
    }
}
