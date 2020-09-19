using AutoMapper;
using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels.IHE;
using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using EStudy.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Services.MVC
{
    public class IHEService : IIHEService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public IHEService(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }

        public async Task<string> CreateIHE(IHECreateModel model)
        {
            var ihe = new IHE
            {
                Name = model.Name,
                ShortName = model.ShortName,
                TimeStudyOfBakalavr = model.TimeStudyOfBakalavr,
                TimeStudyOfMagister = model.TimeStudyOfMagister,
                TypeIHE = GetType(model.IHEType),
                AreaIHE = model.AreaIHE,
                LevelOfAccreditation = model.LevelOfAccreditation,
                CreatedById = model.UserEditId,
                CreatedFromIPAddress = model.IPAddress
            };
            return await unitOfWork.IHEs.CreateAsync(ihe);
        }

        public async Task<IHEViewModel> GetIheById(int Id)
        {
            var ihe = await unitOfWork.IHEs.GetByWhereAsync(d => d.Id == Id);
            return mapper.Map<IHEViewModel>(ihe);
        }

        public TypeIHE GetType(IHEType type)
        {
            switch (type)
            {
                case IHEType.Університет: return TypeIHE.University;
                case IHEType.Інститут: return TypeIHE.Institute;
                case IHEType.Коледж: return TypeIHE.College;
                case IHEType.Технікум: return TypeIHE.TechnicalSchool;
            }
            return default;
        }
    }
}