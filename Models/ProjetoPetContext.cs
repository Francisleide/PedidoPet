using Microsoft.EntityFrameworkCore;

namespace ProjetoPet.Models
{
    public class ProjetoPetContext: DbContext
    {
         public ProjetoPetContext(DbContextOptions<ProjetoPetContext> options) : base(options)
        {

        }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}