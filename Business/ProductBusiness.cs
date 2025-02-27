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

        public async Task<Dictionary<string, dynamic>> GetPetsFromFirebaseAsync()
        {
            try
            {
                var request = new RestRequest("pets.json", Method.Get);  // Get all pets
                var response = await _client.ExecuteAsync(request);

                // Log the raw response content for debugging
                Console.WriteLine("Firebase Response Content: " + response.Content);

                if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
                {
                    // Try deserializing the response content
                    try
                    {
                        var pets = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(response.Content);
                        return pets;
                    }
                    catch (JsonException jsonEx)
                    {
                        Console.WriteLine("Error deserializing Firebase response: " + jsonEx.Message);
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine("Failed to fetch data from Firebase. Status Code: " + response.StatusCode);
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Handle any network issues or other errors
                Console.WriteLine("Error fetching pets from Firebase: " + ex.Message);
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


        public async Task<bool> DeletePetByClientIdAsync(string clientId)
        {
            try
            {
                var request = new RestRequest($"pets/{clientId}.json", Method.Delete);
                var response = await _client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Failed to delete data. Status Code: " + response.StatusCode);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting data: " + ex.Message);
                return false;
            }
        }
    }
}
