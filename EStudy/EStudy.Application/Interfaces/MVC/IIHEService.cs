using EStudy.Application.ViewModels.IHE;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Interfaces.MVC
{
    public interface IIHEService
    {
        Task<IHEViewModel> GetIheById(int Id);
    }
}