using AutoMapper;
using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels.Group;
using EStudy.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Services.MVC
{
    public class AdminService : IAdminService
    {
        private readonly IMapper mapper;
        private IUnitOfWork unitOfWork;
        public AdminService(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }

        public async Task<bool> CreateDatabase()
        {
            return await unitOfWork.Users.CreateDatabaseAsync();
        }

        public async Task<string> CreateTestData()
        {
            return "OK";
        }

        public async Task<bool> DropDatabase()
        {
            return await unitOfWork.Users.DropDatabaseAsync();
        }
    }
}