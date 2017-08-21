using Network.Dommain;
using Network.Infra.Models;
using Network.Infra.Models.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Infra.Contex
{
    public class DbDefaultContext : DbContext
    {
        static DbDefaultContext()
        {
            Database.SetInitializer<DbDefaultContext>(null);
        }

        public DbDefaultContext()
            : base("Name=DbDefaultContext")
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
        public DbSet<networktipo> networktipos { get; set; }

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
            modelBuilder.Configurations.Add(new networktipoMap());
        }
    }
}