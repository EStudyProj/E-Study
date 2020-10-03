using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Infrastructure.Data.Repositories
{
    public class ScheduleRepository : Repository<Schedule>, IScheduleRepository
    {
        public async Task<Schedule> GetScheduleByIdAsync(long Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Schedule>> GetSchedulesByGroupIdAsync(long Id, DateTime date)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Schedule>> GetSchedulesByGroupIdInRangeAsync(long Id, DateTime dateFrom, DateTime dateTo)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Schedule>> GetSchedulesByGroupIdOnWeekAsync(long Id)
        {
            throw new NotImplementedException();
        }
    }
}