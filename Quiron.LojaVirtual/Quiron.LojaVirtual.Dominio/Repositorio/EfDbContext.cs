using Quiron.LojaVirtual.Dominio.Entidade;
using System.Data.Entity;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}
