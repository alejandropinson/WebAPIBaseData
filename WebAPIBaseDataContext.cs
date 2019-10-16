using Microsoft.EntityFrameworkCore;
using WebAPIBaseData.Models;

namespace WebAPIBaseData
{
    public class WebAPIStarterContext : DbContext
    {

        public WebAPIStarterContext(DbContextOptions<WebAPIStarterContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}