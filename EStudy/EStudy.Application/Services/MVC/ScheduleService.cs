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
            throw new NotImplementedException();
        }

        public async Task<List<Schedule>> GetSchedulesByGroupId(long Id, DateTime date)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Schedule>> GetSchedulesByGroupIdInRange(long Id, DateTime dateFrom, DateTime dateTo)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Schedule>> GetSchedulesByGroupIdOnWeek(long Id)
        {
            throw new NotImplementedException();
        }
    }
}