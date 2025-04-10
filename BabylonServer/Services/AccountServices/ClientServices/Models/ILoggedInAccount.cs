

using AshesMapBib.Models.AccountModels;

namespace Services.AccountServices.ClientServices.Models
{
    public interface ILoggedInAccount
    {
        KrakenClientView ClientProfile { get; }
        DateTime CreatedDate { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string Id { get; set; }
        string LastName { get; set; }
        string Token { get;  }

        void ResetUserModel();
        Task SetClient(KrakenClientView _client);

        Task SetToken(string _token);
    }
}