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
    public class GroupRepository : Repository<Group>, IGroupRepository
    {
        public async Task<Group> GetGroupWithStudents(int Id)
        {
            return await db.Groups.AsNoTracking().Include(d => d.Students).FirstOrDefaultAsync(d => d.Id == Id);
        }
    }
}