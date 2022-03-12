using RestApiModelDDDApplication.Dtos;
using RestApiModelDDDomain.Entities;
using System.Collections.Generic;

namespace RestApiModelDDDApplication.Interfaces.Mappers
{
    public interface IMapperClient
    {
        Client MapperDtoToEntity(ClientDto clientDto);
        IEnumerable<ClientDto> MapperListClientsDto(IEnumerable<Client> clients);

        ClientDto MaperEntityToDto(Client client);
    }
}
