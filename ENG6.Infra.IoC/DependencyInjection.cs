using ENG6.Application.Interfaces;
using ENG6.Application.Mappings;
using ENG6.Application.Services;
using ENG6.Domain.Interfaces;
using ENG6.Infra.Data.Context;
using ENG6.Infra.Data.Rerpositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ENG6.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraStructure(this IServiceCollection services,
                                               IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ICLienteService, ClienteService>();
            services.AddAutoMapper(typeof(DomaintToDTOMappingProfile));
            return services;
        }
    }
}
