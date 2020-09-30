using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Infrastructure.Data.Repositories
{
    public class LessonRepository : Repository<Lesson>, ILessonRepository
    {
        public async Task<Lesson> GetLessonWithSubjectById(int Id)
        {
            return await db.Lessons.AsNoTracking().Include(d => d.Subject).SingleOrDefaultAsync(d => d.Id == Id);
        }
    }
}