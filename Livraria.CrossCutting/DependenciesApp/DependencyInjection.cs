using Livraria.Domain.Abstractions;
using Livraria.Infrastructure.Context;
using Livraria.Infrastructure.Respositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Livraria.CrossCutting.DependenciesApp
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependenciesApp(this IServiceCollection services, 
            IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Sqlite");

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(connectionString));

            services.AddScoped<ILivroRepository, LivroRepository>();
            //services.AddScoped<ILivroService, LivroService>();

            return services;
        }
    }
}
