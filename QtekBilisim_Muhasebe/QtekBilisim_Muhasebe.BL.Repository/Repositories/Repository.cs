using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Repository.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly QtekBilisim_MuhasebeContext RepositoryContext;
        public Repository(QtekBilisim_MuhasebeContext _context)
        {
            if (_context == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                RepositoryContext = _context;
            }
        }
        public void AddData(TEntity entity)

        {
            RepositoryContext.Set<TEntity>().Add(entity);
        }

        public void AddDataRange(IEnumerable<TEntity> entities)
        {
            RepositoryContext.Set<TEntity>().AddRange(entities);
        }

        public TEntity FindData(int id)
        {
            return RepositoryContext.Set<TEntity>().Find(id);
        }

        public async Task<TEntity> FindDataAsync(int id)
        {
            return await RepositoryContext.Set<TEntity>().FindAsync(id);
        }

        public TEntity FindDataByExpression(Expression<Func<TEntity, bool>> include)
        {
            return RepositoryContext.Set<TEntity>().Where(include).FirstOrDefault();
        }

        public async Task<TEntity> FindDataByExpressionAsync(Expression<Func<TEntity, bool>> include)
        {
            return await RepositoryContext.Set<TEntity>().Where(include).FirstOrDefaultAsync();
        }

        public bool IsModified(TEntity entity)
        {
            if (RepositoryContext.Entry(entity).State == EntityState.Modified)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<TEntity> ListData()
        {
            return RepositoryContext.Set<TEntity>().ToList();
        }

        public async Task<IEnumerable<TEntity>> ListDataAsync()
        {
            return await RepositoryContext.Set<TEntity>().ToListAsync();
        }

        public IEnumerable<TEntity> ListDataByExpression(Expression<Func<TEntity, bool>> include)
        {
            return RepositoryContext.Set<TEntity>().Where(include).ToList();
        }

        public async Task<IEnumerable<TEntity>> ListDataByExpressionAsync(Expression<Func<TEntity, bool>> include)
        {
            return await RepositoryContext.Set<TEntity>().Where(include).ToListAsync();
        }

        public void RemoveData(TEntity entity)
        {
            RepositoryContext.Set<TEntity>().Remove(entity);
        }

        public void RemoveDataRange(IEnumerable<TEntity> entities)
        {
            RepositoryContext.Set<TEntity>().RemoveRange(entities);
        }
    }
}
