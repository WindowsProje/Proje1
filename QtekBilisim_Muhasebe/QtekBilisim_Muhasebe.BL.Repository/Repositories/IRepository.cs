using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Repository.Repositories
{
    public interface IRepository<TEntity> where TEntity:class
    {
        void AddData(TEntity entity);
        void AddDataRange(IEnumerable<TEntity> entities);

        void RemoveData(TEntity entity);
        void RemoveDataRange(IEnumerable<TEntity> entities);

        TEntity FindData(int id);
        Task<TEntity> FindDataAsync(int id);

        IEnumerable<TEntity> ListData();
        Task<IEnumerable<TEntity>> ListDataAsync();

        TEntity FindDataByExpression(Expression<Func<TEntity, bool>> include);
        Task<TEntity> FindDataByExpressionAsync(Expression<Func<TEntity, bool>> include);

        IEnumerable<TEntity> ListDataByExpression(Expression<Func<TEntity, bool>> include);
        Task<IEnumerable<TEntity>> ListDataByExpressionAsync(Expression<Func<TEntity, bool>> include);

        bool IsModified(TEntity entity);
    }
}
