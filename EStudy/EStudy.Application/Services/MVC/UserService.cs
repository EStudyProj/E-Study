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
        public UserService(IUnitOfWork _UnitOfWork)
        {
            UnitOfWork = _UnitOfWork;
        }

        public async Task<List<UserShortViewModel>> GetAllStudents()
        {
            var students = await UnitOfWork.Users.GetListByWhereAsync(d => d.UserStatus == UserStatus.Student);
            return null;
        }

        public async Task<List<UserShortViewModel>> GetAllTeachers()
        {
            var students = await UnitOfWork.Users.GetListByWhereAsync(d => d.UserStatus == UserStatus.Teacher);
            return null;
        }

        public async Task<UserViewModel> GetUserById(int Id)
        {
            var user = await UnitOfWork.Users.GetByWhereAsync(d => d.Id == Id);
            return null;
        }
    }
}