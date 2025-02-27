using System.Data.Entity;
using PetStore.Data.Models;

namespace PetStore.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            : base("ProductContext") // Uses the connection string name from config
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ProductContext>()); // Ensures DB is created if missing
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
