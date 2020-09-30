using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Infrastructure.Data.Repositories
{
    public class MarkRepository : Repository<Mark>, IMarkRepository
    {
        public async Task<Mark> GetMarkWithDataById(long Id)
        {
            return await db.Marks.AsNoTracking().Include(d => d.Lesson).Include(d => d.Task).SingleOrDefaultAsync(d => d.Id == Id);
        }
    }
}