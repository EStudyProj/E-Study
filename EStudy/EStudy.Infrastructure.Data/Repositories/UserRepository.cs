using EStudy.Domain.Interfaces;
using EStudy.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStudy.Infrastructure.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public async Task<List<User>> GetLastUsers()
        {
            return await db.Users.AsNoTracking().Take(20).OrderByDescending(d => d.CreatedAt).ToListAsync();
        }

        public async Task<User> GetUserWithGroup(int Id)
        {
            return await db.Users.AsNoTracking().Include(d => d.Group).SingleOrDefaultAsync(d => d.Id == Id);
        }
    }
}