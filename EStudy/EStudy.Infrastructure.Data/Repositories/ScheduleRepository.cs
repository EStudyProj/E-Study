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
    public class ScheduleRepository : Repository<Schedule>, IScheduleRepository
    {
        public async Task<List<Schedule>> GetLastAddedSchedules(int count)
        {
            return await db.Schedules
                .AsNoTracking()
                .Include(d => d.ScheduleDayOfWeek)
                .Include(d => d.ScheduleParityOfWeek)
                .Include(d => d.ScheduleLesson)
                .Include(d => d.ScheduleGroup)
                .Include(d => d.ScheduleDiscipline)
                .Include(d => d.ScheduleTeacher)
                .Include(d => d.ScheduleTypeLesson)
                .Include(d => d.ScheduleAudience)
                .Take(count)
                .OrderByDescending(d=>d.CreatedAt)
                .ToListAsync();
        }

        public async Task<List<Schedule>> GetLastEditedSchedules(int count)
        {
            return await db.Schedules
                .AsNoTracking()
                .Include(d => d.ScheduleDayOfWeek)
                .Include(d => d.ScheduleParityOfWeek)
                .Include(d => d.ScheduleLesson)
                .Include(d => d.ScheduleGroup)
                .Include(d => d.ScheduleDiscipline)
                .Include(d => d.ScheduleTeacher)
                .Include(d => d.ScheduleTypeLesson)
                .Include(d => d.ScheduleAudience)
                .Take(count)
                .OrderByDescending(d => d.LastEdited)
                .ToListAsync();
        }

        public async Task<Schedule> GetScheduleByIdAsync(long Id)
        {
            return await db.Schedules
                .AsNoTracking()
                .Include(d => d.ScheduleDayOfWeek)
                .Include(d => d.ScheduleParityOfWeek)
                .Include(d => d.ScheduleLesson)
                .Include(d => d.ScheduleGroup)
                .Include(d => d.ScheduleDiscipline)
                .Include(d => d.ScheduleTeacher)
                .Include(d => d.ScheduleTypeLesson)
                .Include(d => d.ScheduleAudience)
                .SingleOrDefaultAsync(d => d.Id == Id);
        }
    }
}