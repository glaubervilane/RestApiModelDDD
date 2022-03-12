using RestApiModelDDDApplication.Dtos;
using RestApiModelDDDApplication.Interfaces.Mappers;
using RestApiModelDDDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestApiModelDDDApplication.Mappers
{
    public class MapperProduct : IMapperProduct
    {
        public ProductDto MaperEntityToDto(Product product)
        {
            var productDto = new ProductDto()
            {
                Id = product.Id
               ,
                Name = product.Name
               ,
                Price = product.Price
            };
            return productDto;
        }

        public Product MapperDtoToEntity(ProductDto productDto)
        {
            var product = new Product()
            {
                Id = productDto.Id
                ,
                Name = productDto.Name
                ,
                Price = productDto.Price
            };
            return product;
        }

        public IEnumerable<ProductDto> MapperListProductsDto(IEnumerable<Product> products)
        {
            var dto = products.Select(c => new ProductDto
            {
                Id = c.Id,
                Name = c.Name,
                Price = c.Price
            });
            return dto;
        }
    }
}
