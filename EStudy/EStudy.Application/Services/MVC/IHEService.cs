using EStudy.Application.Interfaces.MVC;
using EStudy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.Services.MVC
{
    public class IHEService : IIHEService
    {
        private readonly IIHERepository iheRepos;
        public IHEService(IIHERepository _iheRepos)
        {
            iheRepos = _iheRepos;
        }


    }
}