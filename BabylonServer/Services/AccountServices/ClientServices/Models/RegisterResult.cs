using System.Collections.Generic;

namespace Services.AccountServices.ClientServices.Models
{
    public class RegisterResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
