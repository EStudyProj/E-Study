﻿using AutoMapper;
using EStudy.Application.Interfaces.MVC;
using EStudy.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace EStudy.Application.Services.MVC
{
    public class MarkService : IMarkService
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        public MarkService(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }



    }
}
