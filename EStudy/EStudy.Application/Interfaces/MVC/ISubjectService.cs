using EStudy.Application.ViewModels.Subject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Interfaces.MVC
{
    public interface ISubjectService
    {
        Task<SubjectViewModel> GetSubjectById(int Id);
        Task<List<SubjectViewModel>> GetSubjectsByName(string name);
    }
}