
using Mart_V1.Data.Models.UserProfiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
namespace Mart_V1.Data
{
    public class SQLDbContext : DbContext
    {
        public SQLDbContext(DbContextOptions<SQLDbContext> options) : base(options)
        {
        }
        public DbSet<Roles> Roles { get; set; }

        public DbSet<Users> Users { get; set; }

    }
}
