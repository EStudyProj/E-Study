using EStudy.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Interfaces.MVC
{
    public interface IUserService
    {
        Task<List<UserViewModel>> GetAllUsers();
    }
}