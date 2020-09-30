using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Infrastructure.Data.Repositories
{
    public class TaskRepository : Repository<Task>, ITaskRepository
    {
        public async System.Threading.Tasks.Task<Task> GetTaskWithLessonById(long Id)
        {
            return await db.Tasks.AsNoTracking().Include(d => d.Lesson).SingleOrDefaultAsync(d => d.Id == Id);
        }
    }
}