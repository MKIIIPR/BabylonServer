
using AshesMapBib.Models.AccountModels.ClientModel;

using System.Net.Http.Json;


namespace Services.AccountServices

{
    public class UserEndpoint : IUserEndpoint
    {
        private readonly IAPIHelper _apiHelper;

        public UserEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }



        public async Task CreateUser(CreateUserModel model)
        {
            RegisterModel data = new RegisterModel();
            data.UserName = model.UserName;
            data.Email = model.EmailAddress;
            data.Password = model.Password;

            HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("api/Authenticate/register", data);
            var x = response;

            Console.WriteLine(x);
        }

        public async Task<Dictionary<string, string>> GetAllRoles()
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/sss"))
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

        public async Task GetMyInfos()
        {

            HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync($"/api/KrakenCall/GetAllHeaders");
            var x = response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode == false)
            {
                throw new Exception(response.ReasonPhrase);
            }

        }


    }
}
