using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Application.Interfaces.IServices
{
    public interface IGenericService<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int id);

        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression);

        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression);

        Task<TEntity> AddAsync(TEntity tEntity);

        Task<IQueryable<TEntity>> AddRangeAsync(IQueryable<TEntity> tEntity);

        Task Update(TEntity tEntity);

        Task Remove(TEntity tEntity);

        Task RemoveRange(IQueryable<TEntity> tEntity);
    }
}
