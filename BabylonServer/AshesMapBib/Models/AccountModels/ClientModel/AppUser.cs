using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshesMapBib.Models.AccountModels.ClientModel
{
    public class AppUser
    {
        [Key]
        public string Ref { get; set; }
        public string? BabylonName { get; set; }
        public string? TwitchName { get; set; }
        public string? EmailAddress { get; set; }
        public DateTime? CreatedDate { get; set; }

      
    }
}
