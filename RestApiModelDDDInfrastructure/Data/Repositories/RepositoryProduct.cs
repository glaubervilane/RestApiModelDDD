using RestApiModelDDDomain.Core.Interfaces.Repositories;
using RestApiModelDDDomain.Entities;

namespace RestApiModelDDDInfrastructure.Data.Repositories
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        private readonly SqlContext sqlContext;

        public RepositoryProduct(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
