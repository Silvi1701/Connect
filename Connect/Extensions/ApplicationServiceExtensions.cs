using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Connect.Data;
using Connect.Interfaces;
using Connect.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Connect.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services , IConfiguration config){
             
             services.AddScoped<ITokenService, TokenService>();
             services.AddDbContext<DataContext>(options => 
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            }); 

            return services; 
        }
    }
}