using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Interfaces.MVC
{
    public interface ITestService
    {
        Task<List<TestEntity>> GetAll();
        Task CreateTestData();
    }
}