using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EStudy.Infrastructure.Data.Repositories
{
    public class IHERepository : Repository<IHE>, IIHERepository
    {
        public async Task<IHE> GetIHEWithDepartmentsById(int Id)
        {
            return await db.IHEs.AsNoTracking().Include(d => d.Departments).SingleOrDefaultAsync(d => d.Id == Id);
        }
    }
}