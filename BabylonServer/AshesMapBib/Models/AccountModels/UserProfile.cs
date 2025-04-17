using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AshesMapBib.Models.AccountModels
{

    public class UserProfile 

    {
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [ForeignKey("KrakenClient")]
        public int KrakenClientId { get; set; }

        public string? Name { get; set; } //ProfilName
        
        public string? SignalTag { get; set; } //ProfilTag
        public string? SignalName { get; set; } //ProfilName
        public string? SignalAvatar { get; set; } //ProfilAvatar
        public string? SignalFeet { get; set; } //ProfilFußnote
        public string? ServerId { get; set; } //VerknüpfterServer
        public bool? IsMainProfile{ get; set; }

    }
}
