using GestaoDeProdutosDDD.Domain.Core.Interfaces.Repositories;
using GestaoDeProdutosDDD.Domain.Entities;

namespace GestaoDeProdutosDDD.Infrastructure.Data.Repositories
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly SqlContext sqlContext;

        public RepositoryProduto(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
