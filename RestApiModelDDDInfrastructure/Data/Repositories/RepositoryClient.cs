using RestApiModelDDDomain.Core.Interfaces.Repositories;
using RestApiModelDDDomain.Entities;

namespace RestApiModelDDDInfrastructure.Data.Repositories
{
    public class RepositoryClient : RepositoryBase<Client>, IRepositoryClient
    {
        private readonly SqlContext sqlContext;

        public RepositoryClient(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
