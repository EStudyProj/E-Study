using AutoMapper;
using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels.Specialty;
using EStudy.Domain.Models;
using EStudy.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Services.MVC
{
    public class SpecialtyService : ISpecialtyService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public SpecialtyService(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }

        public async Task<string> CreateSpecialty(SpecialtyCreateModel model)
        {
            if (!await unitOfWork.Departments.IsExistAsync(d => d.Id == model.DepartmentId))
                return "Department by id not found";
            var spec = new Specialty
            {
                CreatedFromIPAddress = model.IPAddress,
                CreatedByUserId = model.UserEditId,
                Name = model.Name,
                Shifr = model.Shifr,
                CodeSpec = model.CodeSpec,
                DepartmentId = model.DepartmentId
            };
            return await unitOfWork.Specialties.CreateAsync(spec);
        }

        public async Task<List<SpecialtyViewModel>> GetSpecialtiesByName(string name)
        {
            var specs = await unitOfWork.Specialties.GetListByWhereAsync(s => s.Name.Contains(name));
            return mapper.Map<List<SpecialtyViewModel>>(specs);
        }

        public async Task<SpecialtyViewModel> GetSpecialtyById(int Id)
        {
            var spec = await unitOfWork.Specialties.GetByWhereAsync(d => d.Id == Id);
            return mapper.Map<SpecialtyViewModel>(spec);
        }
    }
}