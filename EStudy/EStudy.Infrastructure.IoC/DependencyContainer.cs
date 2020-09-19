using EStudy.Application.Interfaces.MVC;
using EStudy.Application.Services.MVC;
using EStudy.Domain.Interfaces;
using EStudy.Infrastructure.Data;
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
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ITestEntityRepository, TestEntityRepository>();
            services.AddScoped<ITestService, TestService>();



            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IIHERepository, IHERepository>();
            services.AddScoped<IIHEService, IHEService>();

            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IDepartmentService, DepartmentService>();
        }

        public static void RegisterAPIServices(this IServiceCollection services)
        {

        }
    }
}