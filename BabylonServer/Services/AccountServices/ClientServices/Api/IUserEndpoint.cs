
using AshesMapBib.Models.AccountModels.ClientModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.AccountServices.ClientServices.Api
{
    public interface IUserEndpoint
    {
        Task<List<UserModel>> GetAll();
        Task<Dictionary<string, string>> GetAllRoles();
        Task AddUserToRole(string userId, string roleName);
        Task RemoveUserFromRole(string userId, string roleName);
        Task CreateUser(CreateUserModel model);
    }
}