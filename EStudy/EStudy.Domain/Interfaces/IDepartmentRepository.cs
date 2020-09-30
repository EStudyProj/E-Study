using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Domain.Interfaces
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        Task<Department> GetDepartmentWithSpecsById(int Id);
    }
}