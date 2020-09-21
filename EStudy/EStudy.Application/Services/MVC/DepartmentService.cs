using AutoMapper;
using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels.Department;
using EStudy.Domain.Models;
using EStudy.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Services.MVC
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IMapper mapper;
        private IUnitOfWork unitOfWork;
        public DepartmentService(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }

        public async Task<string> CreateDepartment(DepartmentCreateModel model)
        {
            if (!await unitOfWork.IHEs.IsExistAsync(d => d.Id == model.IHEId))
                return "IHE by id not found";
            var department = new Department
            {
                CreatedFromIPAddress = model.IPAddress,
                CreatedById = model.UserEditId,
                Name = model.Name,
                Shifr = model.Shifr,
                HeadById = model.HeadById,
                Phone = model.Phone,
                Description = model.Description,
                IHEId = model.IHEId
            };
            return await unitOfWork.Departments.CreateAsync(department);
        }

        public async Task<DepartmentViewModel> GetDepartmentById(int Id)
        {
            var depart = await unitOfWork.Departments.GetByWhereAsync(d => d.Id == Id);
            return mapper.Map<DepartmentViewModel>(depart);
        }

        public async Task<List<DepartmentViewModel>> GetDepartmentsByIHEId(int IheId)
        {
            var depart = await unitOfWork.Departments.GetListByWhereAsync(d => d.IHEId == IheId);
            return mapper.Map<List<DepartmentViewModel>>(depart);
        }
    }
}