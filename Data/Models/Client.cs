using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PetStore.Data.Models
{
    public class Client
    {
        public string ClientId { get; set; } = Guid.NewGuid().ToString(); // Firebase uses string IDs

        [JsonProperty("clientName")]
        public string Name { get; set; }

        [JsonProperty("clientLastName")]
        public string LastName { get; set; }

        [JsonProperty("clientMail")]
        public string Mail { get; set; }

        [JsonProperty("products")]
        public List<Product> Products { get; set; } = new List<Product>(); // Ensure Products is always initialized

        public Client() { }

        public Client(string name, string lastName, string mail, List<Product> products = null)
        {
            ClientId = Guid.NewGuid().ToString(); // Generates unique string ID for Firebase
            Name = name;
            LastName = lastName;
            Mail = mail;
            Products = products ?? new List<Product>();
        }
    }
}
