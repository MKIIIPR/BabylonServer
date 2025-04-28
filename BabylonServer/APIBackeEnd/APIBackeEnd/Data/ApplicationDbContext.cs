using AshesMapBib.Models.AccountModels;
using AshesMapBib.Models.AccountModels.ClientModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AshesMapBib.Models.GameRelatedModels.AshesOfCreation;
using AshesMapBib.Models;

namespace APIBackeEnd.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) // hier wird die Basisklasse aufgerufen
        {
        }
        public DbSet<BabylonClient> BabylonClient { get; set; }
        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<AOCItem> AOC_Item { get; set; } 
        public DbSet<MarketItem> MarketItems { get; set; } 

        // Optional: Falls du zus�tzliche DbSets f�r andere Modelle hinzuf�gen m�chtest
        // public DbSet<SomeModel> SomeModels { get; set; }
    }
}