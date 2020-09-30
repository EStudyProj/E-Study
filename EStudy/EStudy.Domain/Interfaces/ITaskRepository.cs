using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Domain.Interfaces
{
    public interface ITaskRepository : IRepository<Task>
    {
        System.Threading.Tasks.Task<Task> GetTaskWithLessonById(long Id);
    }
}