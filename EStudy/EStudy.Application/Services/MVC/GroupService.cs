using AutoMapper;
using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels.Group;
using EStudy.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Services.MVC
{
    public class GroupService : IGroupService
    {
        private IUnitOfWork unitOfWork;
        private IMapper mapper;
        public GroupService(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }

        public async Task<GroupViewModel> GetGroup(int Id)
        {
            var group = await unitOfWork.Groups.GetGroupWithStudents(Id);
            return mapper.Map<GroupViewModel>(group);
        }

        public async Task<List<GroupViewModel>> GetGroupsByName(string name)
        {
            var groups = await unitOfWork.Groups.GetListByWhereAsync(d => d.GroupName.Contains(name), d => d.CreatedAt, true);
            return mapper.Map<List<GroupViewModel>>(groups);
        }

        public async Task<List<GroupViewModel>> GetGroupsByName(string name, bool IsReleased)
        {
            var groups = await unitOfWork.Groups.GetListByWhereAsync(d => d.GroupName.Contains(name) && d.Released == IsReleased);
            return mapper.Map<List<GroupViewModel>>(groups);
        }
    }
}