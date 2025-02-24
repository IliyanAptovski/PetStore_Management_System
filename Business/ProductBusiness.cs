using PetStore.Data;
using PetStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Business
{
    public class ProductBusiness
    {
        private ProductContext productContext;
        private ProductContext clientContext;

        public void Add(Product product)
        {
            using (productContext = new ProductContext())
            {
                // Add product data to database
                productContext.Products.Add(product);
                productContext.SaveChanges();

            }
        }

        public void Add(Client client)
        {
            using (clientContext = new ProductContext())
            {
                // Add client data to database
                clientContext.Clients.Add(client);
                clientContext.SaveChanges();
            }
        }

        public DataTable Get(int id)
        {
            
            using (productContext = new ProductContext())
            {
                // Retrieve the data
                var retrieveData = from clients in productContext.Clients
                            join products in productContext.Products on clients.ClientId equals products.ClientId
                            where products.ClientId == id
                            let productName = products.Name
                            select new { clients.Name, clients.LastName, clients.Mail, productName, products.Price, products.Count };

                // Convert the query results to a DataTable
                DataTable table = new DataTable();
                table.Columns.Add("Name", typeof(string));
                table.Columns.Add("LastName", typeof(string));
                table.Columns.Add("Mail", typeof(string));
                table.Columns.Add("ProductName", typeof(string));
                table.Columns.Add("Price", typeof(decimal));
                table.Columns.Add("Count", typeof(int));
                foreach (var result in retrieveData)
                {
                    table.Rows.Add(result.Name, result.LastName, result.Mail, result.productName, result.Price, result.Count);
                }

                // Return the DataTable
                return table;
            }
        }

        

        public void Update(int id, string name, string lastName, string mail)
        {
            using (productContext = new ProductContext())
            {
                // Retrieve the records to update
                var recordsToUpdate = from clients in productContext.Clients
                                      join products in productContext.Products on clients.ClientId equals products.ClientId
                                      where clients.ClientId == id
                                      select new { clients, products };

                // Update the records
                foreach (var record in recordsToUpdate)
                {
                    record.clients.Name = name;
                    record.clients.LastName = lastName;
                    record.clients.Mail = mail;
                }

                // Save changes to the database
                productContext.SaveChanges();

            }
        }

        public void Delete(int id)
        {
            using (ProductContext productContext = new ProductContext())
            {
                // Retrieve the records to delete
                var recordsToDelete = from clients in productContext.Clients
                                      join products in productContext.Products on clients.ClientId equals products.ClientId
                                      where clients.ClientId == id
                                      select new { clients, products };

                // Delete the records
                productContext.Clients.RemoveRange(recordsToDelete.Select(r => r.clients));
                productContext.Products.RemoveRange(recordsToDelete.Select(r => r.products));

                // Save changes to the database
                productContext.SaveChanges();
            }
        }
    }
}
