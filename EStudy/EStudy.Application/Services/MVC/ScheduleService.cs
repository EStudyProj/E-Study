using EStudy.Application.Interfaces.MVC;
using EStudy.Domain.Models;
using EStudy.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Services.MVC
{
    public class ScheduleService : IScheduleService
    {
        private readonly IUnitOfWork uniOfWork;

        public ScheduleService(IUnitOfWork _uniOfWork)
        {
            uniOfWork = _uniOfWork;
        }


        public async Task<Schedule> GetScheduleById(long Id)
        {
            return await uniOfWork.Schedules.GetScheduleByIdAsync(Id);
        }

        public async Task<List<Schedule>> GetSchedulesByGroupId(long Id, DateTime date)
        {
            return await uniOfWork.Schedules.GetSchedulesByGroupIdAsync(Id, date);
        }

        public async Task<List<Schedule>> GetSchedulesByGroupIdInRange(long Id, DateTime dateFrom, DateTime dateTo)
        {
            return await uniOfWork.Schedules.GetSchedulesByGroupIdInRangeAsync(Id, dateFrom, dateTo);
        }

        public async Task<List<Schedule>> GetSchedulesByGroupIdOnWeek(long Id)
        {
            return await uniOfWork.Schedules.GetSchedulesByGroupIdOnWeekAsync(Id);
        }
    }
}