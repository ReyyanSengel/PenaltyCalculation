using PenaltyCalculation.Application.Interfaces.IRepositories;
using PenaltyCalculation.Application.Interfaces.IServices;
using PenaltyCalculation.Application.Interfaces.IUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Infrastructure.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        private readonly IGenericRepository<TEntity> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public GenericService(IGenericRepository<TEntity> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<TEntity> AddAsync(TEntity tEntity)
        {
            await _repository.AddAsync(tEntity);
            await _unitOfWork.CommitAsync();
            return tEntity;
        }

        public async Task<IQueryable<TEntity>> AddRangeAsync(IQueryable<TEntity> tEntity)
        {
            await _repository.AddRangeAsync(tEntity);
            await _unitOfWork.CommitAsync();
            return tEntity;
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression)
        {
            await _repository.AnyAsync(expression);
            return true;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task Remove(TEntity tEntity)
        {
            _repository.Remove(tEntity);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveRange(IQueryable<TEntity> tEntity)
        {
            _repository.RemoveRange(tEntity);
            await _unitOfWork.CommitAsync();
        }

        public async Task Update(TEntity tEntity)
        {
            _repository.Update(tEntity);
            await _unitOfWork.CommitAsync();
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
        {
            return _repository.Where(expression);
        }

    }
}
