using AutoMapper;
using EStudy.Application.ViewModels.Department;
using EStudy.Application.ViewModels.IHE;
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
            CreateMap<User, UserShortViewModel>();
            CreateMap<TestEntity, TestEntityViewModel>();
            CreateMap<IHE, IHEViewModel>().ForMember(d => d.Departments, d => d.MapFrom(x => x.Departments));
            CreateMap<Department, DepartmentViewModel>().ForMember(d => d.IHE, d => d.MapFrom(s => s.IHE));
        }
    }
}