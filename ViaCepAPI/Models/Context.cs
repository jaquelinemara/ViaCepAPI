using Microsoft.EntityFrameworkCore;

namespace ViaCepAPI.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Endereco> Enderecos { get; set; }
    }
}