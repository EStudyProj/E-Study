using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Infrastructure.Data.Repositories
{
    public class PresenceRepository : Repository<Presence>, IPresenceRepository
    {
        public async Task<Presence> GetPresenceWithLessonById(long Id)
        {
            return await db.Presences.AsNoTracking().Include(d => d.Lesson).SingleOrDefaultAsync(d => d.Id == Id);
        }
    }
}