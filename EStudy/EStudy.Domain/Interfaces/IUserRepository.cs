﻿using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<List<User>> GetLastUsers();
        Task<User> GetUserWithGroup(int Id);
    }
}