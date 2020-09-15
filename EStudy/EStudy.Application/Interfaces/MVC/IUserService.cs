using EStudy.Application.ViewModels;
using EStudy.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Interfaces.MVC
{
    public interface IUserService
    {
        Task<UserViewModel> GetUserById(int Id);
        Task<List<UserViewModel>> GetAllTeachers();
        Task<List<UserViewModel>> GetAllStudents();
    }
}