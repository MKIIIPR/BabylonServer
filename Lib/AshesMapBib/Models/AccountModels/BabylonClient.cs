using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AshesMapBib.Models.AccountModels
{
    [Table("KrakenClient")]
    public class BabylonClient 
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public int Id { get; set; }

        [Column(TypeName = "varchar(100)", Order = 7)]
        public string Call { get; set; }
        public string EmailAddress { get; set; }
        [Column(Order =1)]
        public string IdentityString { get; set; }

        public string? Tag { get; set; }
        public int? MyProperty { get; set; }
        public string? Avatar { get; set; }
        public string? ProfileCheck { get; set; }
        [Column(TypeName ="decimal(12,4)")]
        public decimal? Rating { get; set; }
        public bool? IsSomething { get; set; }
        public bool? IsSomethingElse { get; set; }
        public bool? IsDifrent { get; set; }
        public string? Feet { get; set; }
        public string? Fsk { get; set; }


        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? Adress { get; set; }
        public DateTime? Dob { get; set; }
        public ICollection<UserProfile>? Profiles { get; set; } = new List<UserProfile>();
       



    }
    public class KrakenClientView
    {

        public string Id { get; set; }
        public string Call { get; set; }
        public string Tag { get; set; }


        public int MyProperty { get; set; }
        public string? Avatar { get; set; }
        public string? ProfileCheck { get; set; }
        public decimal? Rating { get; set; }

        public string Feet { get; set; }
        public string? Fsk { get; set; }


        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string EmailAddress { get; set; }
        public string? Adress { get; set; }
        public DateTime? Dob { get; set; }

    }
}
