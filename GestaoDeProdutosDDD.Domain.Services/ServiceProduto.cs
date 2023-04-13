using GestaoDeProdutosDDD.Domain.Core.Interfaces.Repositories;
using GestaoDeProdutosDDD.Domain.Core.Interfaces.Services;
using GestaoDeProdutosDDD.Domain.Entities;

namespace GestaoDeProdutosDDD.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}
