using AutoMapper;
using EStudy.Application.Interfaces.MVC;
using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using EStudy.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Services.MVC
{
    public class DiplomaService : IDiplomaService
    {
        private readonly IMapper mapper;
        private IUnitOfWork unitOfWork;
        public DiplomaService(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }


        public async Task<Diploma> GetByCode(string code)
        {
            return await unitOfWork.Diplomas.GetByWhereAsync(d => d.UniqCode == code);
        }
    }
}