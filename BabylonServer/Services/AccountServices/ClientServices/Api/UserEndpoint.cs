using AshesMapBib.Models.AccountModels.ClientModel;
using AshesMapBib.Models.Essential;
using Services.AccountServices.ClientServices.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Services.AccountServices.ClientServices.Api
{
    public class UserEndpoint : IUserEndpoint
    {
        private readonly IAPIHelper _apiHelper;

        public UserEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task<List<UserModel>> GetAll()
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/Authenticate/register"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<List<UserModel>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<Response> CreateUser(CreateUserModel model)
        {
            RegisterModel data = new RegisterModel
            {
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password,
                
            };

            try
            {
                Console.WriteLine("Sende folgende Nutzerdaten:");
                Console.WriteLine($"Username: {data.UserName}");
                Console.WriteLine($"Email: {data.Email}");
                Console.WriteLine($"Passwort: {data.Password}");

                HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("api/authenticate/register", data);

                string content = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    // ✅ Erfolg - Response-Objekt zurückgeben
                    var result = JsonSerializer.Deserialize<Response>(content, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    Console.WriteLine("✅ Registrierung erfolgreich!");
                    return result!;
                }
                else
                {
                    Console.WriteLine("❌ Registrierung fehlgeschlagen!");
                    Console.WriteLine($"Status Code: {response.StatusCode}");
                    Console.WriteLine($"Reason: {response.ReasonPhrase}");
                    Console.WriteLine($"Details: {content}");

                    // Fehler-Response zurückgeben
                    return new Response
                    {
                        Status = "Error",
                        Message = $"Registration failed: {content}"
                    };
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("❌ Fehler bei der HTTP-Anfrage:");
                Console.WriteLine(ex.Message);

                return new Response
                {
                    Status = "Error",
                    Message = $"HTTP error: {ex.Message}"
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Ein unerwarteter Fehler ist aufgetreten:");
                Console.WriteLine(ex.Message);

                return new Response
                {
                    Status = "Error",
                    Message = $"Unexpected error: {ex.Message}"
                };
            }
        }


        public async Task<Dictionary<string, string>> GetAllRoles()
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/User/Admin/GetAllRoles"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<Dictionary<string, string>>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task AddUserToRole(string userId, string roleName)
        {
            var data = new { userId, roleName };

            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/User/Admin/AddRole", data))
            {
                if (response.IsSuccessStatusCode == false)
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task RemoveUserFromRole(string userId, string roleName)
        {
            var data = new { userId, roleName };

            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/User/Admin/RemoveRole", data))
            {
                if (response.IsSuccessStatusCode == false)
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
