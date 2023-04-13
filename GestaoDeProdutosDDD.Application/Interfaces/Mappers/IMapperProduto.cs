using GestaoDeProdutosDDD.Application.Dtos;
using GestaoDeProdutosDDD.Domain.Entities;

namespace GestaoDeProdutosDDD.Application.Interfaces.Mappers
{
    public interface IMapperProduto
    {
        Produto MapperDTOToEntity(ProdutoDTO produtoDTO);
        IEnumerable<ProdutoDTO> MapperListProdutosDTO(IEnumerable<Produto> produtos);
        ProdutoDTO MapperEntityToDTO(Produto produtos);
    }
}
