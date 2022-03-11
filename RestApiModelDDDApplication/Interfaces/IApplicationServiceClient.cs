using RestApiModelDDDApplication.Dtos;
using System.Collections.Generic;

namespace RestApiModelDDDApplication.Interfaces
{
    public interface IApplicationServiceClient
    {
        void Add(ClientDto clientDto);
        void Update(ClientDto clienteDto);
        void Remove(ClientDto clientDto);
        IEnumerable<ClientDto> GetAll();
        ClientDto GetById(int id);
    }
}
