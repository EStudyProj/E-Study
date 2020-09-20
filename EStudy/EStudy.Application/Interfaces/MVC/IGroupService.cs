using EStudy.Application.ViewModels.Group;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Interfaces.MVC
{
    public interface IGroupService
    {
        Task<GroupViewModel> GetGroup(int Id);
        Task<List<GroupViewModel>> GetGroupsByName(string name);
        Task<List<GroupViewModel>> GetGroupsByName(string name, bool IsReleased);
    }
}