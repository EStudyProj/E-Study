using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Domain.Interfaces
{
    public interface IIHERepository : IRepository<IHE>
    {
        Task<IHE> GetIHEWithDepartmentsById(int Id);
    }
}