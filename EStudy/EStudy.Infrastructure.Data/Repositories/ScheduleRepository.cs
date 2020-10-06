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

        public async Task<List<Schedule>> GetSchedulesByGroupIdAsync(long Id, DateTime date)
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
                .Where(d => d.ScheduleGroupId == Id && d.DateLesson == date)
                .ToListAsync();
        }

        public async Task<List<Schedule>> GetSchedulesByGroupIdInRangeAsync(long Id, DateTime dateFrom, DateTime dateTo)
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
                .Where(d => d.ScheduleGroup.Id == Id &&
                    (d.DateLesson >= dateFrom && d.DateLesson <= dateTo))
                .ToListAsync();
        }

        public async Task<List<Schedule>> GetSchedulesByGroupIdOnWeekAsync(long Id)
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
                .Where(d => d.ScheduleGroup.Id == Id &&
                    (d.DateLesson >= DateTime.Now && d.DateLesson <= DateTime.Now.AddDays(7)))
                .ToListAsync();
        }

        public async Task<List<Schedule>> GetTodaySchedulesByTeacherIdAsync(int Id)
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
                .Where(d => d.TeacherId == Id && d.DateLesson == DateTime.Today)
                .ToListAsync();
        }
    }
}