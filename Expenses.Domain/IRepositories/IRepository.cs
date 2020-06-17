using System.Collections.Generic;

namespace Expenses.Domain.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        TEntity Get(int id);
        IEnumerable<TEntity> Get();   
        void Remove(TEntity entity);
    }
}
