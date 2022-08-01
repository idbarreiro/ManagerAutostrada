using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repository;

namespace Persistence
{
    public static class ServiceExtensions
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            #region Repositories
            //Inyeccion de dependencias para definir que se va a implementar un Repositorio con la interface sin importar la clase
            services.AddTransient(typeof(IRepositoryAsync<>), typeof(MyRepositoryAsync<>));
            #endregion
        }
    }
}
