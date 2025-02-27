using System;

namespace PetStore.Data.Models
{
    public class Product
    {
        public string Id { get; set; } // Firebase uses string IDs
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public string ClientId { get; set; } // Acts as a reference, no ForeignKey needed

        public Product() { }

        public Product(string name, decimal price, int count, string clientId = null)
        {
            Id = Guid.NewGuid().ToString(); // Generates a unique string ID
            Name = name;
            Price = price;
            Count = count;
            ClientId = clientId;
        }

        public string Display()
        {
            return $"{Name.Replace("\n", " ")}\nQuantity [{Count}]\nPrice for one: ${Price:F2}";
        }
    }
}
