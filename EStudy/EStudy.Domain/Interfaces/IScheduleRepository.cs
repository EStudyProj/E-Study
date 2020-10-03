using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Domain.Interfaces
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
        System.Threading.Tasks.Task<Schedule> GetScheduleByIdAsync(long Id);
        System.Threading.Tasks.Task<List<Schedule>> GetSchedulesByGroupIdAsync(long Id, DateTime date);
        System.Threading.Tasks.Task<List<Schedule>> GetSchedulesByGroupIdOnWeekAsync(long Id);
        System.Threading.Tasks.Task<List<Schedule>> GetSchedulesByGroupIdInRangeAsync(long Id, DateTime dateFrom, DateTime dateTo);
    }
}