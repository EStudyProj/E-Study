using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Domain.Interfaces
{
    public interface IMarkRepository : IRepository<Mark>
    {
        Task<Mark> GetMarkWithDataById(long Id);
    }
}