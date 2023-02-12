using ApiFilme.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiFilme.Data
{
    public class FilmeContext : DbContext
    {
        public DbSet<Filme> Filmes { get; set; }

        public FilmeContext(DbContextOptions<FilmeContext> opts)
            : base(opts)
        {

        }
    }
}
