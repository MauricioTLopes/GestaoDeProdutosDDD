using GestaoDeProdutosDDD.Application.Dtos;
using GestaoDeProdutosDDD.Application.Interfaces;
using GestaoDeProdutosDDD.Application.Interfaces.Mappers;
using GestaoDeProdutosDDD.Application.Mappers;
using GestaoDeProdutosDDD.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutosDDD.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto serviceProduto;
        private readonly IMapperProduto mapperProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto)
        {
            this.serviceProduto = serviceProduto;
            this.mapperProduto = mapperProduto;
        }

        public void Add(ProdutoDTO produtoDTO)
        {
            var produto = mapperProduto.MapperDTOToEntity(produtoDTO);
            serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDTO> GetAll(int qnt)
        {
            var produtos = serviceProduto.GetAll(qnt);
            return mapperProduto.MapperListProdutosDTO(produtos);
        }

        public ProdutoDTO GetById(int id)
        {
            var produtos = serviceProduto.GetById(id);
            return mapperProduto.MapperEntityToDTO(produtos);
        }

        public void Remove(ProdutoDTO produtoDTO)
        {
            var produto = mapperProduto.MapperDTOToEntity(produtoDTO);
            serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDTO produtoDTO)
        {

            var produto = mapperProduto.MapperDTOToEntity(produtoDTO);
            serviceProduto.Update(produto);
        }
    }
}
