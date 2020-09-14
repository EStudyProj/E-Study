using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels;
using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Services.MVC
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepos;
        public UserService(IUserRepository _userRepos)
        {
            userRepos = _userRepos;
        }

    }
}