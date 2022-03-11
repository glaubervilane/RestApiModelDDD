using RestApiModelDDDApplication.Dtos;
using RestApiModelDDDomain.Entities;
using System.Collections.Generic;

namespace RestApiModelDDDInfrastructure.CrossCutting.Interfaces
{
    public interface IMapperClient
    {
        Client MapperDtoToEntity(ClientDto clientDto);
        IEnumerable<ClientDto> MapperListClientsDto(IEnumerable<Client> clients);

        ClientDto MaperEntityToDto(Client client);
    }
}
