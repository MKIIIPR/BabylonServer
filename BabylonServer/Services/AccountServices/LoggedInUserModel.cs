﻿

namespace Services.AccountServices
{
    public class LoggedInUserModel : ILoggedInUserModel
    {
        public string Token { get; set; }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }

        public void ResetUserModel()
        {
            Token = "";
            Id = "";
            FirstName = "";
            LastName = "";
            EmailAddress = "";
            CreatedDate = DateTime.MinValue;
        }
    }
}
