using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Infrastructure.Data.Repositories
{
    public class SubjectRepository : Repository<Subject>, ISubjectRepository
    {
        public async Task<Subject> GetSubjectWithLessonsById(long Id)
        {
            return await db.Subjects.AsNoTracking().Include(d => d.Lessons).SingleOrDefaultAsync(d => d.Id == Id);
        }
    }
}