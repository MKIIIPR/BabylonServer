using AshesMapBib.Models.AccountModels.ClientModel;
using System.Threading.Tasks;


namespace Services.AccountServices

{
    public interface IUserEndpoint
    {
        Task<Dictionary<string, string>> GetAllRoles();
        Task AddUserToRole(string userId, string roleName);
        Task RemoveUserFromRole(string userId, string roleName);
        Task CreateUser(CreateUserModel model);
        Task GetMyInfos();
    }
}