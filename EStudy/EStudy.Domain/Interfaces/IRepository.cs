using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EStudy.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<string> CreateAsync(TEntity entity);
        Task<string> EditAsync(TEntity entity);
        Task<string> EditRangeAsync(IList<TEntity> entities);
        Task<string> RemoveAsync(TEntity entity);
        Task<string> RemoveRangeAsync(IList<TEntity> entities);
        Task<TEntity> GetByWhereAsync(Expression<Func<TEntity, bool>> match);
        Task<TEntity> GetByWhereAsTrackingAsync(Expression<Func<TEntity, bool>> match);
        Task<List<TEntity>> GetListByWhereAsTrackingAsync(Expression<Func<TEntity, bool>> match);
        Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match);
        Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match, Expression<Func<TEntity, int, TEntity>> selector);
        Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match, int count, int offset);
        Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match, Expression<Func<TEntity, int, TEntity>> selector, int count, int offset);
        Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match, Expression<Func<TEntity, object>> orderBy, bool OrderByAscending);
        Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match, Expression<Func<TEntity, object>> orderBy, Expression<Func<TEntity, int, TEntity>> selector, bool OrderByAscending);
        Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match, Expression<Func<TEntity, object>> orderBy, bool OrderByAscending, int count, int offset);
        Task<List<TEntity>> GetListByWhereAsync(Expression<Func<TEntity, bool>> match, Expression<Func<TEntity, object>> orderBy, Expression<Func<TEntity, int, TEntity>> selector, bool OrderByAscending, int count, int offset);
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, int, TEntity>> selector);
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<TEntity, bool>> match);
        Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> match);
        Task<string> SaveAsync();
    }
}