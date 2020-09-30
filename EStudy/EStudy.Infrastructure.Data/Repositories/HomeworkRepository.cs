using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Infrastructure.Data.Repositories
{
    public class HomeworkRepository : Repository<Homework>, IHomeworkRepository
    {
        public async Task<Homework> GetHomeworkWithTaskById(int Id)
        {
            return await db.Homeworks.AsNoTracking().Include(d => d.Task).SingleOrDefaultAsync(d => d.Id == Id);
        }
    }
}