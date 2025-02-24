using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Data.Models
{
    public class Client
    {
        ProductContext clientContext = new ProductContext();

        [Key]
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public Client() { }

        public Client(string name, string lastName, string mail)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Mail = mail;
        }

        public int GetCurrentId()
        {
            // Starting id
            int Id = 1;
            using (clientContext = new ProductContext())
            {
                // Check for empty database
                if (clientContext.Clients.ToList().Count != 0)
                {
                    // Loop through all clients and get the highest id
                    foreach (var item in clientContext.Clients.ToList())
                    {
                        if (item.ClientId > Id)
                        {
                            Id = item.ClientId;
                        }
                    }
                } else return Id;
                
            }
            return Id;
        }
    }
}
