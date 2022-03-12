using RestApiModelDDDApplication.Dtos;
using RestApiModelDDDomain.Entities;
using System.Collections.Generic;

namespace RestApiModelDDDApplication.Interfaces.Mappers
{
    public interface IMapperProduct
    {
        Product MapperDtoToEntity(ProductDto productDto);
        IEnumerable<ProductDto> MapperListProductsDto(IEnumerable<Product> products);

        ProductDto MaperEntityToDto(Product product);
    }
}
