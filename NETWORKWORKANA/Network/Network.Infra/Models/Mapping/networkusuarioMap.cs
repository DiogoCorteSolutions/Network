using Network.Dommain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Network.Infra.Models.Mapping
{
    public class networkusuarioMap : EntityTypeConfiguration<networkusuario>
    {
        public networkusuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.IdUsuario);

            // Properties
            this.Property(t => t.NomeFuncionario)
                .HasMaxLength(300);

            this.Property(t => t.CodigoFuncionario)
                .HasMaxLength(100);

            this.Property(t => t.Setor)
                .HasMaxLength(100);

            this.Property(t => t.Carteiratrabalho)
                .HasMaxLength(200);

            this.Property(t => t.CarteiraMotorista)
                .HasMaxLength(100);

            this.Property(t => t.Rg)
                .HasMaxLength(100);

            this.Property(t => t.Cpf)
                .HasMaxLength(100);

            this.Property(t => t.Endereco)
                .HasMaxLength(200);

            this.Property(t => t.Bairro)
                .HasMaxLength(300);

            this.Property(t => t.Cidade)
                .HasMaxLength(200);

            this.Property(t => t.Ud)
                .HasMaxLength(100);

            this.Property(t => t.Fone1)
                .HasMaxLength(100);

            this.Property(t => t.Fone2)
                .HasMaxLength(100);

            this.Property(t => t.Senha)
                .HasMaxLength(100);

            this.Property(t => t.Status);

            this.Property(t => t.Perfil)
                .HasMaxLength(100);

            this.Property(t => t.Sexo)
                .HasMaxLength(100);

            this.Property(t => t.Email)
                .HasMaxLength(100);





            // Table & Column Mappings
            this.ToTable("networkusuario");
            this.Property(t => t.IdUsuario).HasColumnName("IdUsuario");
            this.Property(t => t.NomeFuncionario).HasColumnName("NomeFuncionario");
            this.Property(t => t.CodigoFuncionario).HasColumnName("CodigoFuncionario");
            this.Property(t => t.Setor).HasColumnName("Setor");
            this.Property(t => t.DataEmaissao).HasColumnName("DataEmaissao");
            this.Property(t => t.Salario).HasColumnName("Salario");
            this.Property(t => t.Carteiratrabalho).HasColumnName("Carteiratrabalho");
            this.Property(t => t.CarteiraMotorista).HasColumnName("CarteiraMotorista");
            this.Property(t => t.Rg).HasColumnName("Rg");
            this.Property(t => t.Cpf).HasColumnName("Cpf");
            this.Property(t => t.Endereco).HasColumnName("Endereco");
            this.Property(t => t.Bairro).HasColumnName("Bairro");
            this.Property(t => t.Cidade).HasColumnName("Cidade");
            this.Property(t => t.Ud).HasColumnName("Ud");
            this.Property(t => t.Fone1).HasColumnName("Fone1");
            this.Property(t => t.Fone2).HasColumnName("Fone2");
            this.Property(t => t.Senha).HasColumnName("Senha");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Perfil).HasColumnName("Perfil");
            this.Property(t => t.Sexo).HasColumnName("Sexo");
            this.Property(t => t.Email).HasColumnName("Email");
        }
    }
}
