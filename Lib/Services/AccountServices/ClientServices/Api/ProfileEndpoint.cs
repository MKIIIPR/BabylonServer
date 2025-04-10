
using AshesMapBib.Models.AccountModels.ClientModel;
using Services.AccountServices.ClientServices.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services.AccountServices.ClientServices.Api
{
    public class ProfileEndpoint : IProfileEndpoint
    {
        private readonly IAPIHelper _apiHelper;

        public ProfileEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task AddProfile( UserProfileView toAdd)
        {
            HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/UserProfiles/AddProfile", toAdd);
            
                if (response.IsSuccessStatusCode == false)
                {
                    throw new Exception(response.ReasonPhrase);
                }
                
            
            
        }

        public Task EditProfile(UserProfileView toEdit)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserProfileView>> GetProfiles()
        {
            throw new NotImplementedException();
        }

        public Task RemoveProfile(string userId, string toRemove)
        {
            throw new NotImplementedException();
        }
    }
}
