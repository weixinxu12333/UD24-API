using Microsoft.EntityFrameworkCore;

namespace UD24_API.Models
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options)
            : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

    }
}
