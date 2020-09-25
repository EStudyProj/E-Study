using AutoMapper;
using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels.TestEntity;
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
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public TestService(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }

        public async System.Threading.Tasks.Task CreateTestData()
        {
            await unitOfWork.Tests.CreateAsync(new TestEntity
            {
                Guid = Guid.NewGuid().ToString()
            });
        }

        public async Task<List<TestEntityViewModel>> GetAll()
        {
            var elements = await unitOfWork.Tests.GetAllAsync();
            return mapper.Map<List<TestEntityViewModel>>(elements);
        }
    }
}