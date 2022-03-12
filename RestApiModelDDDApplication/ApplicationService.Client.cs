using RestApiModelDDDApplication.Dtos;
using RestApiModelDDDApplication.Interfaces;
using RestApiModelDDDApplication.Interfaces.Mappers;
using RestApiModelDDDomain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModelDDDApplication
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient serviceClient;
        private readonly IMapperClient mapperClient;

        public ApplicationServiceClient(IServiceClient serviceClient, IMapperClient mapperClient)
        {
            this.serviceClient = serviceClient;
            this.mapperClient = mapperClient;
        }
        public void Add(ClientDto clientDto)
        {
            var client= mapperClient.MapperDtoToEntity(clientDto);
            serviceClient.Add(client);
        }

        public IEnumerable<ClientDto> GetAll()
        {
            var clients = serviceClient.GetAll();
            return mapperClient.MapperListClientsDto(clients);
        }

        public ClientDto GetById(int id)
        {
            var client = serviceClient.GetById(id);
            return mapperClient.MaperEntityToDto(client);
        }

        public void Remove(ClientDto clientDto)
        {
            var client = mapperClient.MapperDtoToEntity(clientDto);
            serviceClient.Remove(client);
        }

        public void Update(ClientDto clienteDto)
        {
            var client = mapperClient.MapperDtoToEntity(clienteDto);
            serviceClient.Update(client);
        }
    }
}
