using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Domain.Interfaces
{
    public interface IGroupSubjectRepository : IRepository<GroupSubject>
    {
        Task<List<Group>> GetGroupsBySubjectId(int Id);
        Task<List<Subject>> GetSubjectsByGroupId(int Id);
    }
}