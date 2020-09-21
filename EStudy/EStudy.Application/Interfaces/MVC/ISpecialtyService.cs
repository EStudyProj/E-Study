using EStudy.Application.ViewModels.Specialty;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Interfaces.MVC
{
    public interface ISpecialtyService
    {
        Task<string> CreateSpecialty(SpecialtyCreateModel model);
        Task<SpecialtyViewModel> GetSpecialtyById(int Id);
        Task<List<SpecialtyViewModel>> GetSpecialtiesByName(string name);
    }
}