using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DomainInfra.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}