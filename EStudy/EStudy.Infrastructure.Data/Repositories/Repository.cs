using EStudy.Domain.Interfaces;
using EStudy.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Infrastructure.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public readonly EStudyContext db;
        public readonly DbSet<TEntity> dbSet;
        public Repository()
        {
            db = new EStudyContext();
            dbSet = db.Set<TEntity>();
        }

        public async Task<int> CountAsync()
        {
            return await db.Set<TEntity>().CountAsync();
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> match)
        {
            return await db.Set<TEntity>().CountAsync(match);
        }

        public async Task<string> CreateAsync(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
            return await SaveAsync();
        }

        public async Task<string> EditAsync(TEntity entity)
        {
            db.Set<TEntity>().Update(entity);
            return await SaveAsync();
        }

        public async Task<string> EditRangeAsync(IList<TEntity> entities)
        {
            db.Set<TEntity>().UpdateRange(entities);
            return await SaveAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, int, TEntity>> selector)
        {
            return await db.Set<TEntity>().AsNoTracking().Select(selector).ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await db.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetByWhereAsTrackingAsync(Expression<Func<TEntity, bool>> match)
        {
            return await db.Set<TEntity>().FirstOrDefaultAsync(match);
        }

        public async Task<TEntity> GetByWhereAsync(Expression<Func<TEntity, bool>> match)
        {
            return await db.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(match);
        }

        public async Task<List<TEntity>> GetListByWhereAsTrackingAsync(Expression<Func<TEntity, bool>> match)
        {
            return await db.Set<TEntity>().Where(match).ToListAsync();
        }

        public async Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match)
        {
            return await db.Set<TEntity>().AsNoTracking().Where(match).ToListAsync();
        }

        public async Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match, Expression<Func<TEntity, int, TEntity>> selector)
        {
            return await db.Set<TEntity>().AsNoTracking().Where(match).Select(selector).ToListAsync();
        }

        public async Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match, int count, int offset)
        {
            return await db.Set<TEntity>().AsNoTracking().Where(match).Take(count).Skip(offset).ToListAsync();
        }

        public async Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match, Expression<Func<TEntity, int, TEntity>> selector, int count, int offset)
        {
            return await db.Set<TEntity>().AsNoTracking().Where(match).Select(selector).Take(count).Skip(offset).ToListAsync();
        }

        public async Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match, Expression<Func<TEntity, object>> orderBy, bool OrderByAscending)
        {
            if (OrderByAscending)
                return await db.Set<TEntity>().AsNoTracking().Where(match).OrderBy(orderBy).ToListAsync();
            return await db.Set<TEntity>().AsNoTracking().Where(match).OrderByDescending(orderBy).ToListAsync();
        }

        public async Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match, Expression<Func<TEntity, object>> orderBy, Expression<Func<TEntity, int, TEntity>> selector, bool OrderByAscending)
        {
            if (OrderByAscending)
                return await db.Set<TEntity>().AsNoTracking().Where(match).Select(selector).OrderBy(orderBy).ToListAsync();
            return await db.Set<TEntity>().AsNoTracking().Where(match).Select(selector).OrderByDescending(orderBy).ToListAsync();
        }

        public async Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match, Expression<Func<TEntity, object>> orderBy, bool OrderByAscending, int count, int offset)
        {
            if (OrderByAscending)
                return await db.Set<TEntity>().AsNoTracking().Where(match).OrderBy(orderBy).Take(count).Skip(offset).ToListAsync();
            return await db.Set<TEntity>().AsNoTracking().Where(match).OrderByDescending(orderBy).Take(count).Skip(offset).ToListAsync();
        }

        public async Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match, Expression<Func<TEntity, object>> orderBy, Expression<Func<TEntity, int, TEntity>> selector, bool OrderByAscending, int count, int offset)
        {
            if (OrderByAscending)
                return await db.Set<TEntity>().AsNoTracking().Where(match).Select(selector).OrderBy(orderBy).Take(count).Skip(offset).ToListAsync();
            return await db.Set<TEntity>().AsNoTracking().Where(match).Select(selector).OrderByDescending(orderBy).Take(count).Skip(offset).ToListAsync();
        }

        public async Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> match)
        {
            return await db.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(match) != null ? true : false;
        }

        public async Task<string> RemoveAsync(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);
            return await SaveAsync();
        }

        public async Task<string> RemoveRangeAsync(IList<TEntity> entities)
        {
            db.Set<TEntity>().RemoveRange(entities);
            return await SaveAsync();
        }

        public async Task<string> SaveAsync()
        {
            return await db.SaveChangesAsync() > 0 ? "OK" : "Error";
        }
    }
}