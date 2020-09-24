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

        public async Task<GroupViewModel> GetFullInfoByDepartmentId(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<GroupViewModel> GetFullInfoByGroupId(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<GroupViewModel> GetFullInfoByIHEId(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<GroupViewModel> GetFullInfoBySpecialtyId(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<GroupViewModel> GetFullInfoByUserId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}