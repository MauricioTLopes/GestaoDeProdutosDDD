using GestaoDeProdutosDDD.Application.Dtos;
using GestaoDeProdutosDDD.Application.Interfaces.Mappers;
using GestaoDeProdutosDDD.Domain.Entities;

namespace GestaoDeProdutosDDD.Application.Mappers
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDTOToEntity(ProdutoDTO produtoDTO)
        {
            var produto = new Produto()
            {
                Id = produtoDTO.Id,
                Descricao = produtoDTO.Descricao,
                Situacao = produtoDTO.Situacao,
                DataFabricacao = produtoDTO.DataFabricacao,
                DataValidade = produtoDTO.DataValidade,
                CodigoFornecedor = produtoDTO.CodigoFornecedor,
                DescricaoFornecedor = produtoDTO.DescricaoFornecedor,
                CNPJFornecedor = produtoDTO.CNPJFornecedor

            };
            return produto;
    }

        public ProdutoDTO MapperEntityToDTO(Produto produto)
        {
            var produtoDTO = new ProdutoDTO();
            if (produto != null) {

                produtoDTO.Id = produto.Id;
                produtoDTO.Descricao = produto.Descricao;
                produtoDTO.Situacao = produto.Situacao;
                produtoDTO.DataFabricacao = produto.DataFabricacao;
                produtoDTO.DataValidade = produto.DataValidade;
                produtoDTO.CodigoFornecedor = produto.CodigoFornecedor;
                produtoDTO.DescricaoFornecedor = produto.DescricaoFornecedor;
                produtoDTO.CNPJFornecedor = produto.CNPJFornecedor;
            }

            return produtoDTO;
        }

        public IEnumerable<ProdutoDTO> MapperListProdutosDTO(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(c => new ProdutoDTO
            {
                Id = c.Id,
                Descricao = c.Descricao,
                Situacao = c.Situacao,
                DataFabricacao = c.DataFabricacao,
                DataValidade = c.DataValidade,
                CodigoFornecedor = c.CodigoFornecedor,
                DescricaoFornecedor = c.DescricaoFornecedor,
                CNPJFornecedor = c.CNPJFornecedor,

            });

            return dto;
        }
    }
}
