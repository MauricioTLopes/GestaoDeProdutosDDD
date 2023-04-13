using GestaoDeProdutosDDD.Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeProdutosDDD.Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext sqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public void Add(TEntity entity)
        {
            try
            {
                sqlContext.Set<TEntity>().Add(entity);
                sqlContext.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll(int qnt)
        {
            return sqlContext.Set<TEntity>().ToList().Take(qnt);
        }

        public TEntity GetById(int id)
        {
            return sqlContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity entity)
        {
            try
            {
                sqlContext.Set<TEntity>().Update(entity); 
                sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                sqlContext.Entry(entity).State = EntityState.Modified;
                sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
