using EStudy.Application.ViewModels.IHE;
using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Interfaces.MVC
{
    public interface IIHEService
    {
        Task<string> CreateIHE(IHECreateModel model);
        Task<IHEViewModel> GetIheById(int Id);
        TypeIHE GetType(IHEType type);
    }
}