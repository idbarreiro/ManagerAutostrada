using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Controla que EFCore va a mantener toda la información sobre una instancia de la entidad en su rastreador de cambios
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
    }
}
