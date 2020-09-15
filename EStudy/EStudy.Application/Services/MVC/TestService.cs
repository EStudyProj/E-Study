using EStudy.Application.Interfaces.MVC;
using EStudy.Domain.Models;
using EStudy.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Services.MVC
{
    public class TestService : ITestService
    {
        private IUnitOfWork unitOfWork;
        public TestService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public async Task<TestEntity> GetAll()
        {
            return await unitOfWork.Tests.GetAllAsync();
        }
    }
}