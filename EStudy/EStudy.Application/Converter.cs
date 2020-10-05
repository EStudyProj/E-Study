using AutoMapper;
using EStudy.Application.ViewModels.Department;
using EStudy.Application.ViewModels.DIploma;
using EStudy.Application.ViewModels.File;
using EStudy.Application.ViewModels.Group;
using EStudy.Application.ViewModels.Homework;
using EStudy.Application.ViewModels.IHE;
using EStudy.Application.ViewModels.Lesson;
using EStudy.Application.ViewModels.Mark;
using EStudy.Application.ViewModels.Presence;
using EStudy.Application.ViewModels.Schedule.ScheduleAudience;
using EStudy.Application.ViewModels.Schedule.ScheduleDayOfWeek;
using EStudy.Application.ViewModels.Schedule.ScheduleDiscipline;
using EStudy.Application.ViewModels.Schedule.ScheduleGroup;
using EStudy.Application.ViewModels.Schedule.ScheduleLesson;
using EStudy.Application.ViewModels.Schedule.ScheduleParityOfWeek;
using EStudy.Application.ViewModels.Schedule.ScheduleTypeLesson;
using EStudy.Application.ViewModels.Specialty;
using EStudy.Application.ViewModels.Subject;
using EStudy.Application.ViewModels.Task;
using EStudy.Application.ViewModels.TestEntity;
using EStudy.Application.ViewModels.User;
using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application
{
    public class Converter : Profile
    {
        public Converter()
        {
            CreateMap<Department, DepartmentViewModel>().ForMember(d => d.IHE, d => d.MapFrom(s => s.IHE));
            CreateMap<Diploma, DiplomaViewModel>().ForMember(d => d.User, d => d.MapFrom(s => s.User));
            CreateMap<File, FileViewModel>();
            CreateMap<Group, GroupViewModel>().ForMember(g => g.Students, e => e.MapFrom(s => s.Students))
                .ForMember(d => d.Specialty, s => s.MapFrom(e => e.Specialty));
            CreateMap<Homework, HomeworkViewModel>()
                .ForMember(d => d.Task, d => d.MapFrom(s => s.Task));
            CreateMap<IHE, IHEViewModel>().ForMember(d => d.Departments, d => d.MapFrom(x => x.Departments));
            CreateMap<Lesson, LessonViewModel>()
                .ForMember(d => d.Subject, d => d.MapFrom(e => e.Subject))
                .ForMember(d => d.Tasks, d => d.MapFrom(e => e.Tasks))
                .ForMember(d => d.Marks, d => d.MapFrom(e => e.Marks))
                .ForMember(d => d.Presences, d => d.MapFrom(e => e.Presences));
            CreateMap<Mark, MarkViewModel>()
                .ForMember(d => d.Task, d => d.MapFrom(s => s.Task))
                .ForMember(d => d.Lesson, d => d.MapFrom(s => s.Lesson));
            CreateMap<Presence, PresenceViewModel>()
                .ForMember(d => d.Lesson, d => d.MapFrom(s => s.Lesson));
            CreateMap<ScheduleAudience, ScheduleAudienceViewModel>();
            CreateMap<ScheduleDayOfWeek, ScheduleDayOfWeekViewModel>();
            CreateMap<ScheduleDiscipline, ScheduleDisciplineViewModel>();
            CreateMap<ScheduleGroup, ScheduleGroupViewModel>();
            CreateMap<ScheduleLesson, ScheduleLessonViewModel>();
            CreateMap<ScheduleParityOfWeek, ScheduleParityOfWeekViewModel>();
            CreateMap<ScheduleTypeLesson, ScheduleTypeLessonViewModel>();
            CreateMap<Specialty, SpecialtyViewModel>()
                .ForMember(d => d.Groups, d => d.MapFrom(s => s.Groups))
                .ForMember(d => d.Department, d => d.MapFrom(s => s.Department));
            CreateMap<Subject, SubjectViewModel>()
                .ForMember(e => e.FinalMark, d => d.MapFrom(s => s.FinalMark.ToString()))
                .ForMember(d => d.TypeSubject, e => e.MapFrom(s => s.TypeSubject.ToString()));
            CreateMap<Task, TaskViewModel>()
                .ForMember(d => d.Lesson, d => d.MapFrom(s => s.Lesson))
                .ForMember(d => d.Homeworks, d => d.MapFrom(s => s.Homeworks))
                .ForMember(d => d.Marks, d => d.MapFrom(s => s.Marks));
            CreateMap<TestEntity, TestEntityViewModel>();
            CreateMap<User, UserViewModel>()
                .ForMember(d => d.Group, d => d.MapFrom(s => s.Group));
            CreateMap<User, UserShortViewModel>().ForMember(d => d.Photo, s => s.MapFrom(e => e.PhotoPath));
        }
    }
}