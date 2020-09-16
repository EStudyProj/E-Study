using AutoMapper;
using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels;
using EStudy.Application.ViewModels.User;
using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using EStudy.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Services.MVC
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly IMapper mapper;
        public UserService(IUnitOfWork _UnitOfWork, IMapper _mapper)
        {
            UnitOfWork = _UnitOfWork;
            mapper = _mapper;
        }

        public async Task<List<UserShortViewModel>> GetAllStudents()
        {
            var students = await UnitOfWork.Users.GetListByWhereAsync(d => d.UserStatus == UserStatus.Student);
            return mapper.Map<List<UserShortViewModel>>(students);
        }

        public async Task<List<UserShortViewModel>> GetAllTeachers()
        {
            var teachers = await UnitOfWork.Users.GetListByWhereAsync(d => d.UserStatus == UserStatus.Teacher);
            return mapper.Map<List<UserShortViewModel>>(teachers);
        }

        public async Task<UserViewModel> GetUserById(int Id)
        {
            var userdb = await UnitOfWork.Users.GetByWhereAsync(d => d.Id == Id);
            return mapper.Map<UserViewModel>(userdb);
        }

        public async Task<UserViewModel> GetUserByUsername(string username)
        {
            var userdb = await UnitOfWork.Users.GetByWhereAsync(d => d.Username == username);
            return mapper.Map<UserViewModel>(userdb);
        }

        public async Task<List<UserShortViewModel>> GetUsersByEmail(string email)
        {
            var usersdb = await UnitOfWork.Users.GetListByWhereAsync(d => d.Email == email);
            return mapper.Map<List<UserShortViewModel>>(usersdb);
        }

        public async Task<List<UserShortViewModel>> GetUsersByPhone(string phone)
        {
            var usersdb = await UnitOfWork.Users.GetListByWhereAsync(d => d.Phone == phone);
            return mapper.Map<List<UserShortViewModel>>(usersdb);
        }
    }
}