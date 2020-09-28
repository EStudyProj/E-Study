using AutoMapper;
using EStudy.Application.Interfaces.MVC;
using EStudy.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace EStudy.Application.Services.MVC
{
    public class HomeworkService : IHomeworkService
    {
        private readonly IMapper mapper;
        private IUnitOfWork unitOfWork;
        public HomeworkService(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }


    }
}
