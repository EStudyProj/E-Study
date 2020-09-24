using EStudy.Application.ViewModels.Group;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Interfaces.MVC
{
    public interface IAdminService
    {
        Task<GroupViewModel> GetFullInfoByGroupId(int Id);
        Task<GroupViewModel> GetFullInfoByIHEId(int Id);
        Task<GroupViewModel> GetFullInfoByUserId(int Id);
        Task<GroupViewModel> GetFullInfoBySpecialtyId(int Id);
        Task<GroupViewModel> GetFullInfoByDepartmentId(int Id);
    }
}