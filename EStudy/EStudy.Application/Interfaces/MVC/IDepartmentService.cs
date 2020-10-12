using EStudy.Application.ViewModels.Department;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Interfaces.MVC
{
    public interface IDepartmentService
    {
        Task<string> CreateDepartment(DepartmentCreateModel model);
        Task<DepartmentEditModel> GetForEditDepartment(int Id);
        Task<string> EditDepartment(DepartmentEditModel model);
        Task<List<DepartmentViewModel>> GetDepartmentsByIHEId(int IheId);
        Task<DepartmentViewModel> GetDepartmentById(int Id);
    }
}