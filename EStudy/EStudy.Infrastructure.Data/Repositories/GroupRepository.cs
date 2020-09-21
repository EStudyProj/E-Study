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

        public async Task<Group> GetMyGroupsWithStudents(int UserId)
        {
            var user = await db.Users.AsNoTracking().Select(d => new User { Id = d.Id, GroupId = d.GroupId }).FirstOrDefaultAsync(d => d.Id == UserId);
            return await db.Groups.AsNoTracking()
                .Include(d => d.Students)
                .FirstOrDefaultAsync(d => d.Id == user.GroupId);
        }
    }
}