using AutoMapper;
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
        }
    }
}