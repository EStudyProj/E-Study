using EStudy.Application.ViewModels.Group;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Interfaces.MVC
{
    public interface IAdminService
    {
        Task<string> CreateTestData();
        Task<bool> CreateDatabase();
        Task<bool> DropDatabase();
    }
}