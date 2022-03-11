using RestApiModelDDDomain.Core.Interfaces.Repositories;
using RestApiModelDDDomain.Core.Interfaces.Services;
using RestApiModelDDDomain.Entities;

namespace RestApiModelDDDomain.Services
{
    public class ServiceProduct : ServiceBase<Product>, IServiceProduct
    {
        private readonly IRepositoryProduct repositoryProduct;

        public ServiceProduct(IRepositoryProduct repositoryProduct) : base(repositoryProduct)
        {
            this.repositoryProduct = repositoryProduct;
        }
    }
}
