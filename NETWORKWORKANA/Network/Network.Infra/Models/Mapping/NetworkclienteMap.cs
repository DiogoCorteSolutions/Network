using Network.Dommain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Network.Infra.Models.Mapping
{
    public class NetworkclienteMap : EntityTypeConfiguration<Networkcliente>
    {
        public NetworkclienteMap()
        {
            // Primary Key
            this.HasKey(t => t.IdCliente);

            // Properties
            this.Property(t => t.NomeRazaoSocial)
                .HasMaxLength(500);

            this.Property(t => t.ApelidoNomeFantasia)
                .HasMaxLength(500);

            this.Property(t => t.Contato)
                .HasMaxLength(200);

            this.Property(t => t.Telefone1)
                .HasMaxLength(100);

            this.Property(t => t.Telefone2)
                .HasMaxLength(100);

            this.Property(t => t.Fax)
                .HasMaxLength(100);

            this.Property(t => t.Cnpj)
                .HasMaxLength(100);

            this.Property(t => t.Cpf)
                .HasMaxLength(100);

            this.Property(t => t.IncricaoEstadualRg)
                .HasMaxLength(100);

            this.Property(t => t.Endereco1)
                .HasMaxLength(100);

            this.Property(t => t.Numero1)
                .HasMaxLength(100);

            this.Property(t => t.Cidade1)
                .HasMaxLength(100);

            this.Property(t => t.Uf1)
                .HasMaxLength(100);

            this.Property(t => t.Cep1)
                .HasMaxLength(100);

            this.Property(t => t.Endereco2)
                .HasMaxLength(100);

            this.Property(t => t.Numero2)
                .HasMaxLength(100);

            this.Property(t => t.Cidade2)
                .HasMaxLength(100);

            this.Property(t => t.Uf2)
                .HasMaxLength(100);

            this.Property(t => t.Cep2)
                .HasMaxLength(100);

            this.Property(t => t.Referencia1)
                .HasMaxLength(100);

            this.Property(t => t.TelefoneReferencia1)
                .HasMaxLength(100);

            this.Property(t => t.EmailReferencia1)
                .HasMaxLength(100);

            this.Property(t => t.Referencia2)
                .HasMaxLength(100);

            this.Property(t => t.TelefoneReferncia2)
                .HasMaxLength(100);

            this.Property(t => t.CodMunicipio)
                .HasMaxLength(100);

            this.Property(t => t.TipoRegiao)
                .HasMaxLength(400);

            this.Property(t => t.ProfissaoRamo)
                .HasMaxLength(400);

            this.Property(t => t.VendedorAtendente)
                .HasMaxLength(300);

            this.Property(t => t.Trasportadora)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Networkcliente");
            this.Property(t => t.IdCliente).HasColumnName("IdCliente");
            this.Property(t => t.NomeRazaoSocial).HasColumnName("NomeRazaoSocial");
            this.Property(t => t.ApelidoNomeFantasia).HasColumnName("ApelidoNomeFantasia");
            this.Property(t => t.Contato).HasColumnName("Contato");
            this.Property(t => t.DataCadastro).HasColumnName("DataCadastro");
            this.Property(t => t.Telefone1).HasColumnName("Telefone1");
            this.Property(t => t.Telefone2).HasColumnName("Telefone2");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.Cnpj).HasColumnName("Cnpj");
            this.Property(t => t.Cpf).HasColumnName("Cpf");
            this.Property(t => t.IncricaoEstadualRg).HasColumnName("IncricaoEstadualRg");
            this.Property(t => t.Endereco1).HasColumnName("Endereco1");
            this.Property(t => t.Numero1).HasColumnName("Numero1");
            this.Property(t => t.Cidade1).HasColumnName("Cidade1");
            this.Property(t => t.Uf1).HasColumnName("Uf1");
            this.Property(t => t.Cep1).HasColumnName("Cep1");
            this.Property(t => t.Endereco2).HasColumnName("Endereco2");
            this.Property(t => t.Numero2).HasColumnName("Numero2");
            this.Property(t => t.Cidade2).HasColumnName("Cidade2");
            this.Property(t => t.Uf2).HasColumnName("Uf2");
            this.Property(t => t.Cep2).HasColumnName("Cep2");
            this.Property(t => t.Referencia1).HasColumnName("Referencia1");
            this.Property(t => t.TelefoneReferencia1).HasColumnName("TelefoneReferencia1");
            this.Property(t => t.EmailReferencia1).HasColumnName("EmailReferencia1");
            this.Property(t => t.DataNascimento).HasColumnName("DataNascimento");
            this.Property(t => t.Referencia2).HasColumnName("Referencia2");
            this.Property(t => t.TelefoneReferncia2).HasColumnName("TelefoneReferncia2");
            this.Property(t => t.Renda).HasColumnName("Renda");
            this.Property(t => t.Credito).HasColumnName("Credito");
            this.Property(t => t.CodMunicipio).HasColumnName("CodMunicipio");
            this.Property(t => t.Spc).HasColumnName("Spc");
            this.Property(t => t.Serasa).HasColumnName("Serasa");
            this.Property(t => t.TeleCheque).HasColumnName("TeleCheque");
            this.Property(t => t.Bloqueado).HasColumnName("Bloqueado");
            this.Property(t => t.Classificacao).HasColumnName("Classificacao");
            this.Property(t => t.Sexo).HasColumnName("Sexo");
            this.Property(t => t.TipoRegiao).HasColumnName("TipoRegiao");
            this.Property(t => t.ProfissaoRamo).HasColumnName("ProfissaoRamo");
            this.Property(t => t.VendedorAtendente).HasColumnName("VendedorAtendente");
            this.Property(t => t.Trasportadora).HasColumnName("Trasportadora");
            this.Property(t => t.Observacao).HasColumnName("Observacao");
        }
    }
}
