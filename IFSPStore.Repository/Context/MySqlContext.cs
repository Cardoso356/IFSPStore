using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace IFSPStore.Repository.Context
{
    public class MySQLContext : DbContext //é uma herança do DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options):base(options)
        {
            Database.EnsureCreated(); // cria o banco caso não exista
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<VendaItem> Vendaitens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ao criar o banco, isso considera as configurações do mapeamento
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Grupo>(new GrupoMap().Configure);
            modelBuilder.Entity<Produto>(new ProdutoMap().Configure);
            modelBuilder.Entity<Venda>(new VendaMap().Configure);
            modelBuilder.Entity<VendaItem>(new VendaItemMap().Configure);
            
        }
    }
}
