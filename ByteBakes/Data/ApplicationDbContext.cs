using ByteBakes.Models.Categories;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ByteBakes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Subscriber> Subscribers { get; set; }
        public object Category { get; internal set; }

        public DbSet<Category> Categories
        {
            get;
            set;
        }

    }
}
