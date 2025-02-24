using PetStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            : base("name=ProductContext")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
