using AutoMapper;
using EStudy.Application.ViewModels.Department;
using EStudy.Application.ViewModels.Group;
using EStudy.Application.ViewModels.IHE;
using EStudy.Application.ViewModels.Subject;
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
            CreateMap<User, UserViewModel>();
            CreateMap<User, UserShortViewModel>().ForMember(d => d.Photo, s => s.MapFrom(e => e.PhotoPath));
            CreateMap<TestEntity, TestEntityViewModel>();
            CreateMap<IHE, IHEViewModel>().ForMember(d => d.Departments, d => d.MapFrom(x => x.Departments));
            CreateMap<Department, DepartmentViewModel>().ForMember(d => d.IHE, d => d.MapFrom(s => s.IHE));
            CreateMap<Group, GroupViewModel>().ForMember(g => g.Students, e => e.MapFrom(s => s.Students))
                .ForMember(d => d.Specialty, s => s.MapFrom(e => e.Specialty));
            CreateMap<Subject, SubjectViewModel>().ForMember(e => e.FinalMark, d => d.MapFrom(s => s.FinalMark.ToString()))
                .ForMember(d => d.TypeSubject, e => e.MapFrom(s => s.TypeSubject.ToString()));
        }
    }
}