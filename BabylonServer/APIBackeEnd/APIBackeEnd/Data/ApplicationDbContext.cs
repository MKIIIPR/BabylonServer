using AshesMapBib.Models.AccountModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIBackeEnd.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) // hier wird die Basisklasse aufgerufen
        {
        }
        public DbSet<BabylonClient> BabylonClient { get; set; }
        // Optional: Falls du zusätzliche DbSets für andere Modelle hinzufügen möchtest
        // public DbSet<SomeModel> SomeModels { get; set; }
    }
}