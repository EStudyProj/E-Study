using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Infrastructure.Data.Repositories
{
    public class GroupSubjectRepository : Repository<GroupSubject>, IGroupSubjectRepository
    {
        public async Task<List<Group>> GetGroupsBySubjectId(int Id)
        {
            return await db.GroupSubjects.AsNoTracking()
                .Include(d => d.Group)
                .Where(d => d.SubjectId == Id)
                .Select(d => d.Group)
                .ToListAsync();
        }

        public async Task<List<Subject>> GetSubjectsByGroupId(int Id)
        {
            return await db.GroupSubjects.AsNoTracking()
                .Include(d => d.Subject)
                .Where(d => d.GroupId == Id)
                .Select(d => d.Subject)
                .ToListAsync();
        }
    }
}