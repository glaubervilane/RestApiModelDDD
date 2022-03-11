using RestApiModelDDDomain.Core.Interfaces.Repositories;
using RestApiModelDDDomain.Core.Interfaces.Services;
using RestApiModelDDDomain.Entities;

namespace RestApiModelDDDomain.Services
{
    public class ServiceClient : ServiceBase<Client>, IServiceClient
    {
        private readonly IRepositoryClient repositoryClient;

        public ServiceClient(IRepositoryClient repositoryClient) : base(repositoryClient)
        {
            this.repositoryClient = repositoryClient;
        }
    }
}
