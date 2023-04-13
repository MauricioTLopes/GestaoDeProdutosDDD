using GestaoDeProdutosDDD.Domain.Core.Interfaces.Repositories;
using GestaoDeProdutosDDD.Domain.Core.Interfaces.Services;

namespace GestaoDeProdutosDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            this.repositoryBase = repositoryBase;
        }
        public void Add(TEntity entity)
        {
            repositoryBase.Add(entity);
        }

        public IEnumerable<TEntity> GetAll(int qnt)
        {
           return repositoryBase.GetAll(qnt);
        }

        public TEntity GetById(int id)
        {
            return repositoryBase.GetById(id);
        }

        public void Remove(TEntity entity)
        {
            repositoryBase.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            repositoryBase.Update(entity);
        }
    }
}
