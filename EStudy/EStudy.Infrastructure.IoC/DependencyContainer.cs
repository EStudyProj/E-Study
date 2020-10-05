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
            services.AddScoped<IAdminService, AdminService>();



            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IDepartmentService, DepartmentService>();

            services.AddScoped<IDiplomaRepository, DiplomaRepository>();
            services.AddScoped<IDiplomaService, DiplomaService>();

            services.AddScoped<IFileRepository, FileRepository>();
            services.AddScoped<IFileService, FileService>();

            services.AddScoped<IGroupRepository, GroupRepository>();
            services.AddScoped<IGroupService, GroupService>();

            services.AddScoped<IGroupSubjectRepository, GroupSubjectRepository>();

            services.AddScoped<IHomeworkRepository, HomeworkRepository>();
            services.AddScoped<IHomeworkService, HomeworkService>();

            services.AddScoped<IIHERepository, IHERepository>();
            services.AddScoped<IIHEService, IHEService>();

            services.AddScoped<ILessonRepository, LessonRepository>();
            services.AddScoped<ILessonService, LessonService>();

            services.AddScoped<IMarkRepository, MarkRepository>();
            services.AddScoped<IMarkService, MarkService>();

            services.AddScoped<IPresenceRepository, PresenceRepository>();
            services.AddScoped<IPresenceService, PresenceService>();

            services.AddScoped<IScheduleAudienceRepository, ScheduleAudienceRepository>();

            services.AddScoped<IScheduleDayOfWeekRepository, ScheduleDayOfWeekRepository>();

            services.AddScoped<IScheduleDisciplineRepository, ScheduleDisciplineRepository>();

            services.AddScoped<IScheduleGroupRepository, ScheduleGroupRepository>();

            services.AddScoped<IScheduleLessonRepository, ScheduleLessonRepository>();

            services.AddScoped<IScheduleParityOfWeekRepository, ScheduleParityOfWeekRepository>();

            services.AddScoped<IScheduleTypeLessonRepository, ScheduleTypeLessonRepository>();

            services.AddScoped<IScheduleRepository, ScheduleRepository>();
            services.AddScoped<IScheduleService, ScheduleService>();

            services.AddScoped<ISpecialtyRepository, SpecialtyRepository>();
            services.AddScoped<ISpecialtyService, SpecialtyService>();

            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<ISubjectService, SubjectService>();

            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<ITaskService, TaskService>();

            services.AddScoped<ITestEntityRepository, TestEntityRepository>();
            services.AddScoped<ITestService, TestService>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
        }

        public static void RegisterAPIServices(this IServiceCollection services)
        {

        }
    }
}