using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Domain.Interfaces
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
        System.Threading.Tasks.Task<Schedule> GetScheduleByIdAsync(long Id);

        System.Threading.Tasks.Task<List<Schedule>> GetLastAddedSchedules(int count);

        System.Threading.Tasks.Task<List<Schedule>> GetLastEditedSchedules(int count);
    }
}