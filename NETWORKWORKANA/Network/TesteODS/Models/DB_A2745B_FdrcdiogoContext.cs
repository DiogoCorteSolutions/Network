using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TesteODS.Models.Mapping;

namespace TesteODS.Models
{
    public partial class DB_A2745B_FdrcdiogoContext : DbContext
    {
        static DB_A2745B_FdrcdiogoContext()
        {
            Database.SetInitializer<DB_A2745B_FdrcdiogoContext>(null);
        }

        public DB_A2745B_FdrcdiogoContext()
            : base("Name=DB_A2745B_FdrcdiogoContext")
        {
        }

        public DbSet<Networkcliente> Networkclientes { get; set; }
        public DbSet<networkcomposicao> networkcomposicaos { get; set; }
        public DbSet<networkcontasapagar> networkcontasapagars { get; set; }
        public DbSet<networkcontasareceber> networkcontasarecebers { get; set; }
        public DbSet<networkfornecedore> networkfornecedores { get; set; }
        public DbSet<networkperfil> networkperfils { get; set; }
        public DbSet<networkproduto> networkprodutos { get; set; }
        public DbSet<networkusuario> networkusuarios { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<teste> testes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new NetworkclienteMap());
            modelBuilder.Configurations.Add(new networkcomposicaoMap());
            modelBuilder.Configurations.Add(new networkcontasapagarMap());
            modelBuilder.Configurations.Add(new networkcontasareceberMap());
            modelBuilder.Configurations.Add(new networkfornecedoreMap());
            modelBuilder.Configurations.Add(new networkperfilMap());
            modelBuilder.Configurations.Add(new networkprodutoMap());
            modelBuilder.Configurations.Add(new networkusuarioMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new testeMap());
        }
    }
}
