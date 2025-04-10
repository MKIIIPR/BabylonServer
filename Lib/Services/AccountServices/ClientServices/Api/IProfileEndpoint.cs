
using AshesMapBib.Models.AccountModels.ClientModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.AccountServices.ClientServices.Api
{
    public interface IProfileEndpoint
        
    {
        Task<List<UserProfileView>> GetProfiles();        
        Task AddProfile(UserProfileView toAdd);
        Task RemoveProfile(string userId, string toRemove);
        Task EditProfile(UserProfileView toEdit);
    }
}
