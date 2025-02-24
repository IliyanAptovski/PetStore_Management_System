using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        public Product() { }

        public Product(string name, decimal price, int count)
        {
            this.Name = name;
            this.Price = price;
            this.Count = count;
        }

        public Product(string name, decimal price, int count, int clientId)
        {
            this.Name = name;
            this.Price = price;
            this.Count = count;
            this.ClientId = clientId;
        }

        public string Dispaly()
        {
            return $"{this.Name.Replace("\n", " ")}\nQuantity [{this.Count}]\nPrice for one: ${this.Price:f2}";
        }
    }
}
