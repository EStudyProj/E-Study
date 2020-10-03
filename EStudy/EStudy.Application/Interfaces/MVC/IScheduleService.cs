﻿using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Application.Interfaces.MVC
{
    public interface IScheduleService
    {
        Task<Schedule> GetScheduleById(long Id);
        Task<List<Schedule>> GetSchedulesByGroupId(int Id, DateTime date);
        Task<List<Schedule>> GetSchedulesByGroupIdOnWeek(int Id);
        Task<List<Schedule>> GetSchedulesByGroupIdInRange(int Id, DateTime dateFrom, DateTime dateTo);
    }
}