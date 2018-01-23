using DesafioEmbraer.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DesafioEmbraer.DAL
{
    public class LojaContext : DbContext
    {

        public LojaContext() : base("LojaContext")
        {
        }

        public DbSet<DESAFIO_EMBRAER_PRODUTO> DESAFIO_EMBRAER_PRODUTOS { get; set; }
        public DbSet<DESAFIO_EMBRAER_VENDA> DESAFIO_EMBRAER_VENDAS { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}