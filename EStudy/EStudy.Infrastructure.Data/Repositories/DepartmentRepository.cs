using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Infrastructure.Data.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public async Task<Department> GetDepartmentWithSpecsById(int Id)
        {
            return await db.Departments.AsNoTracking().Include(d => d.Specialties).SingleOrDefaultAsync(d => d.Id == Id);
        }
    }
}