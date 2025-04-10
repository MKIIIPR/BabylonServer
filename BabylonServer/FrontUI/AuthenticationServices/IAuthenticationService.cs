using Portal.Models;
using System.Threading.Tasks;

namespace FrontUI.AuthenticationServices
{
    public interface IAuthenticationService
    {
        Task<AuthenticatedUserModel> Login(AuthenticationUserModel userForAuthentication);
        Task<AuthenticatedUserModel> GetAccess(AuthenticationUserModel userForAuthentication);
        Task Logout();
    }
}