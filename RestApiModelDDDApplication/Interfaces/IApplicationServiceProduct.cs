using RestApiModelDDDApplication.Dtos;
using System.Collections.Generic;

namespace RestApiModelDDDApplication.Interfaces
{
    public interface IApplicationServiceProduct
    {
        void Add(ProductDto productDto);
        void Update(ProductDto productDto);
        void Remove(ProductDto productDto);
        IEnumerable<ProductDto> GetAll();
        ProductDto GetById(int id);
    }
}
