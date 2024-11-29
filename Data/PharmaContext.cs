

    using Microsoft.EntityFrameworkCore;
    using Pharma.Models;

    namespace Pharma.Data
    {
        public class PharmaContext : DbContext
        {
            public PharmaContext(DbContextOptions<PharmaContext> options) : base(options)
            {
            }

            public DbSet<Medicine> Medicines { get; set; }
            public DbSet<Order> Orders { get; set; }
        }
    }


