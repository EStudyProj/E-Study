using AutoMapper;
using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels.IHE;
using EStudy.Domain.Interfaces;
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

        public async Task<IHEViewModel> GetIheById(int Id)
        {
            var ihe = await unitOfWork.IHEs.GetByWhereAsync(d => d.Id == Id);
            return mapper.Map<IHEViewModel>(ihe);
        }
    }
}