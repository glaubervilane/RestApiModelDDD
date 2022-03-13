using Autofac;
using RestApiModelDDDApplication;
using RestApiModelDDDApplication.Interfaces;
using RestApiModelDDDApplication.Interfaces.Mappers;
using RestApiModelDDDApplication.Mappers;
using RestApiModelDDDInfrastructure.Data.Repositories;
using RestApiModelDDDomain.Core.Interfaces.Repositories;
using RestApiModelDDDomain.Core.Interfaces.Services;
using RestApiModelDDDomain.Services;

namespace RestApiModelDDDInfrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceClient>().As<IApplicationServiceClient>();
            builder.RegisterType<ApplicationServiceProduct>().As<IApplicationServiceProduct>();
            builder.RegisterType<ServiceClient>().As<IServiceClient>();
            builder.RegisterType<ServiceProduct>().As<IServiceProduct>();
            builder.RegisterType<RepositoryClient>().As<IRepositoryClient>();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();
            builder.RegisterType<MapperClient>().As<IMapperClient>();
            builder.RegisterType<MapperProduct>().As<IMapperProduct>();

            #endregion

        }
    }
}
