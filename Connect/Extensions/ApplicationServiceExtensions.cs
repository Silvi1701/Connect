using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Connect.Data;
using Connect.Helpers;
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
             

             services.Configure<CloudinarySettings>(config.GetSection("CloudinarySettings"));
             services.AddScoped<ITokenService, TokenService>();
             services.AddScoped<IPhotoService, PhotoService>();
             services.AddScoped<ILikesRepository, LikesRepository>();
             services.AddScoped<LogUserActivity>();
             services.AddScoped<IUserRepository, UserRepository>();
             services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
             services.AddDbContext<DataContext>(options => 
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            }); 

            return services; 
        }
    }
}