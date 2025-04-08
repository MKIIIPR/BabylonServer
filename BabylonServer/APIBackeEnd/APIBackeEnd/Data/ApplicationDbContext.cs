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

        // Optional: Falls du zus�tzliche DbSets f�r andere Modelle hinzuf�gen m�chtest
        // public DbSet<SomeModel> SomeModels { get; set; }
    }
}