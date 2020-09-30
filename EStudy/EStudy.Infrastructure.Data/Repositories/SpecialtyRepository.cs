using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Infrastructure.Data.Repositories
{
    public class SpecialtyRepository : Repository<Specialty>, ISpecialtyRepository
    {
        public async Task<Specialty> GetSpecialtyWithGroupsById(int Id)
        {
            return await db.Specialties.AsNoTracking().Include(d => d.Groups).SingleOrDefaultAsync(d => d.Id == Id);
        }
    }
}