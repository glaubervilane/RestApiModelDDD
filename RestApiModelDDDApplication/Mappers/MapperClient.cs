using RestApiModelDDDApplication.Dtos;
using RestApiModelDDDApplication.Interfaces.Mappers;
using RestApiModelDDDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestApiModelDDDApplication.Mappers
{
    public class MapperClient : IMapperClient
    {
        public ClientDto MaperEntityToDto(Client client)
        {
            var clientDto = new ClientDto()
            {
                Id = client.Id
               ,
                FirstName = client.FirstName
               ,
                LastName = client.LastName
               ,
                Email = client.Email
            };
            return clientDto;
        }

        public Client MapperDtoToEntity(ClientDto clientDto)
        {
            var client = new Client()
            {
                Id = clientDto.Id
                ,
                FirstName = clientDto.FirstName
                ,
                LastName = clientDto.LastName
                ,
                Email = clientDto.Email
            };
            return client;
        }

        public IEnumerable<ClientDto> MapperListClientsDto(IEnumerable<Client> clients)
        {
            var dto = clients.Select(c => new ClientDto
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Email = c.Email
            });
            return dto;
        }
    }
}
