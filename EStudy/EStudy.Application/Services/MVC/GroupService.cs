using AutoMapper;
using EStudy.Application.Interfaces.MVC;
using EStudy.Application.ViewModels.Group;
using EStudy.Domain.Models;
using EStudy.Infrastructure.Data;
using Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Services.MVC
{
    public class GroupService : IGroupService
    {
        private IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public GroupService(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }

        public async Task<string> CreateGroup(GroupCreateModel model)
        {
            if (!await unitOfWork.Specialties.IsExistAsync(d => d.Id == model.SpecialtyId))
                return "Specialty by id not found";
            var group = new Group
            {
                CreatedFromIPAddress = model.IPAddress,
                CreatedByUserId = model.UserEditId,
                GroupName = model.GroupName,
                IndexItemToChanged = model.IndexItemToChanged,
                CodeForConnect = Generator.GetString(10),
                SpecialtyId = model.SpecialtyId
            };
            return await unitOfWork.Groups.CreateAsync(group);
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

        public async Task<List<GroupViewModel>> GetGroupsBySubjectId(int Id)
        {
            var groups = await unitOfWork.GroupSubjects.GetGroupsBySubjectId(Id);
            return mapper.Map<List<GroupViewModel>>(groups);
        }

        public async Task<GroupViewModel> GetMyGroup(int UserId)
        {
            var group = await unitOfWork.Groups.GetMyGroupsWithStudents(UserId);
            return mapper.Map<GroupViewModel>(group);
        }
    }
}