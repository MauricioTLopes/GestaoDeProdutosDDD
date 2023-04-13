using Autofac;
using GestaoDeProdutosDDD.Application;
using GestaoDeProdutosDDD.Application.Interfaces;
using GestaoDeProdutosDDD.Application.Interfaces.Mappers;
using GestaoDeProdutosDDD.Application.Mappers;
using GestaoDeProdutosDDD.Domain.Core.Interfaces.Repositories;
using GestaoDeProdutosDDD.Domain.Core.Interfaces.Services;
using GestaoDeProdutosDDD.Domain.Services;
using GestaoDeProdutosDDD.Infrastructure.Data.Repositories;

namespace GestaoDeProdutosDDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        { 
            #region IOC
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion
        }
    }
}
