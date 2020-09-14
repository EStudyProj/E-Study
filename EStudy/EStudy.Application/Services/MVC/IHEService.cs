using EStudy.Application.Interfaces.MVC;
using EStudy.Domain.Interfaces;
using EStudy.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.Services.MVC
{
    public class IHEService : IIHEService
    {
        private readonly IUnitOfWork unitOfWork;
        public IHEService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }


    }
}