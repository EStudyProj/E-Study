using EStudy.Application.Interfaces.MVC;
using EStudy.Application.Services.MVC;
using EStudy.Domain.Interfaces;
using EStudy.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Infrastructure.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterMVCServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
        }

        public static void RegisterAPIServices(this IServiceCollection services)
        {

        }
    }
}