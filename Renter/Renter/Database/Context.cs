using Microsoft.EntityFrameworkCore;
using Renter.Models;

namespace Renter.Database
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipType { get; set; }

        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=RenterDatabase;Trusted_Connection=True;");

        }
    }
}
