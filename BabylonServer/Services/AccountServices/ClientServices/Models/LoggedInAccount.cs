
using AshesMapBib.Models.AccountModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.AccountServices.ClientServices.Models
{
    public class LoggedInAccount : ILoggedInAccount
    {
        public LoggedInAccount()
        {
        }

        public string Token { get; private set; }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public KrakenClientView ClientProfile { get; private set; }

        public void ResetUserModel()
        {
            Token = "";
            Id = "";
            FirstName = "";
            LastName = "";
            EmailAddress = "";
            CreatedDate = DateTime.MinValue;
            ClientProfile = new KrakenClientView();
        }
        public async Task SetClient(KrakenClientView _client)
        {
            ClientProfile = _client;
            

        }
        public async Task SetToken(string token)
        {
            Token   = token;
        }
    }
}
