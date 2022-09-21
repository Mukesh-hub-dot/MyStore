using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class MyStoreContext : DbContext
    {
        public MyStoreContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<Product> Products { get; set; }

    }
}
