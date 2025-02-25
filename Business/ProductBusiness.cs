using Newtonsoft.Json;
using PetStore.Data;
using PetStore.Data.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PetStore.Business
{
    public class ProductBusiness
    {
        private readonly RestClient _client;
        private const string FirebaseUrl = "https://petstore-management-system-default-rtdb.europe-west1.firebasedatabase.app/";

        public ProductBusiness()
        {
            _client = new RestClient(FirebaseUrl);
        }

        public async Task AddPetAsync(Product product, Client client)
        {
            try
            {
                // Combine product and client into a single object
                var pet = new
                {
                    ClientId = Guid.NewGuid().ToString(),  // Generate a unique ID for the client
                    ClientName = client.Name,
                    ClientLastName = client.LastName,
                    ClientMail = client.Mail,
                    ProductId = Guid.NewGuid().ToString(),  // Generate a unique ID for the product
                    ProductName = product.Name,
                    ProductPrice = product.Price,
                    ProductCount = product.Count
                };

                var petJson = JsonConvert.SerializeObject(pet);  // Serialize the object to JSON
                var request = new RestRequest("pets.json", Method.Post);  // Use POST to add the pet
                request.AddParameter("application/json", petJson, ParameterType.RequestBody);

                var response = await _client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    Console.WriteLine("Client and Product added successfully.");
                }
                else
                {
                    Console.WriteLine("Error adding pet: " + response.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while adding pet: " + ex.Message);
            }
        }

        public async Task<DataTable> GetPetAsync(string clientId)
        {
            try
            {
                // Make the request to Firebase to fetch data for a specific clientId
                var request = new RestRequest($"pets/{clientId}.json", Method.Get);  // Adjust path if necessary
                var response = await _client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    // Log the response content to see what we are getting back
                    Console.WriteLine("Response Content: " + response.Content);

                    // Deserialize the response into a Client object
                    var client = JsonConvert.DeserializeObject<Client>(response.Content);

                    // Check if the client data exists
                    if (client != null && client.Products != null && client.Products.Count > 0)
                    {
                        // Create DataTable to hold the data
                        var dataTable = new DataTable();
                        dataTable.Columns.Add("ClientName", typeof(string));
                        dataTable.Columns.Add("ClientLastName", typeof(string));
                        dataTable.Columns.Add("ClientMail", typeof(string));
                        dataTable.Columns.Add("ProductName", typeof(string));
                        dataTable.Columns.Add("ProductPrice", typeof(decimal));
                        dataTable.Columns.Add("ProductCount", typeof(int));

                        // Populate DataTable with the retrieved data
                        foreach (var product in client.Products)
                        {
                            dataTable.Rows.Add(
                                client.Name,
                                client.LastName,
                                client.Mail,
                                product.Name,
                                product.Price,
                                product.Count
                            );
                        }

                        return dataTable;
                    }
                    else
                    {
                        Console.WriteLine("No products found for client ID: " + clientId);
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine("Failed to fetch data. Status Code: " + response.StatusCode);
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., network issues)
                Console.WriteLine("Error fetching data: " + ex.Message);
                return null;
            }
        }




        public async Task UpdatePetAsync(string petId, Product updatedProduct, Client updatedClient)
        {
            try
            {
                // Combine the updated product and client details
                var pet = new
                {
                    ClientId = petId,
                    ClientName = updatedClient.Name,
                    ClientLastName = updatedClient.LastName,
                    ClientMail = updatedClient.Mail,
                    ProductId = petId,
                    ProductName = updatedProduct.Name,
                    ProductPrice = updatedProduct.Price,
                    ProductCount = updatedProduct.Count
                };

                var petJson = JsonConvert.SerializeObject(pet);  // Serialize to JSON
                var request = new RestRequest($"pets/{petId}.json", Method.Put);  // Use PUT to update the pet
                request.AddParameter("application/json", petJson, ParameterType.RequestBody);

                var response = await _client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    Console.WriteLine("Pet updated successfully.");
                }
                else
                {
                    Console.WriteLine("Error updating pet: " + response.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        public async Task DeletePetByClientIdAsync(string clientId)
        {
            if (string.IsNullOrEmpty(clientId) || _client == null)
            {
                return;
            }

            // Fetch all pets from Firebase
            var request = new RestRequest("pets.json", Method.Get);
            var response = await _client.ExecuteAsync(request);

            if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
            {
                return;
            }

            // Deserialize JSON response
            var pets = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(response.Content);

            if (pets == null || pets.Count == 0)
            {
                return;
            }

            // Find the pet entry by matching ClientId
            var petToDelete = pets.FirstOrDefault(p => p.Value.ClientId != null && p.Value.ClientId.ToString() == clientId);

            if (string.IsNullOrEmpty(petToDelete.Key))
            {
                return;
            }

            // Send DELETE request to remove pet from Firebase
            var deleteRequest = new RestRequest($"pets/{petToDelete.Key}.json", Method.Delete);
            await _client.ExecuteAsync(deleteRequest);
        }



    }
}
