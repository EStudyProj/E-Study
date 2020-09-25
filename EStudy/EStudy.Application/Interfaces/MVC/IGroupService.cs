using EStudy.Application.ViewModels.Group;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Interfaces.MVC
{
    public interface IGroupService
    {
        Task<string> CreateGroup(GroupCreateModel model);
        Task<GroupViewModel> GetGroup(int Id);
        Task<GroupViewModel> GetMyGroup(int UserId);
        Task<List<GroupViewModel>> GetGroupsByName(string name);
        Task<List<GroupViewModel>> GetGroupsByName(string name, bool IsReleased);
        Task<List<GroupViewModel>> GetGroupsBySubjectId(int Id);
    }
}