using GestaoDeProdutosDDD.Application.Dtos;

namespace GestaoDeProdutosDDD.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDTO produtoDTO);
        void Update(ProdutoDTO produtoDTO);
        void Remove(ProdutoDTO produtoDTO);
        IEnumerable<ProdutoDTO> GetAll(int qnt);
        ProdutoDTO GetById(int id);

    }
}
