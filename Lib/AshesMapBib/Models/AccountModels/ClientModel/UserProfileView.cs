using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshesMapBib.Models.AccountModels.ClientModel
{
    public class UserProfileView

    {

        public string Id { get; set; } = String.Empty;
        [ForeignKey("KrakenClient")]
        public string KrakenClientId { get; set; } = String.Empty;

        public string? Name { get; set; } //ProfilName

        public string? SignalTag { get; set; } //ProfilTag
        public string? SignalName { get; set; } //ProfilName
        public string? SignalAvatar { get; set; } //ProfilAvatar
        public string? SignalFeet { get; set; } //ProfilFußnote
        public string? ServerId { get; set; } //VerknüpfterServer
        public bool? IsMainProfile { get; set; }

    }
}
