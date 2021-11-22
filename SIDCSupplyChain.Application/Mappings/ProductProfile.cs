using SIDCSupplyChain.Application.Features.Products.Commands.Create;
using SIDCSupplyChain.Application.Features.Products.Queries.GetAllCached;
using SIDCSupplyChain.Application.Features.Products.Queries.GetAllPaged;
using SIDCSupplyChain.Application.Features.Products.Queries.GetById;
using SIDCSupplyChain.Domain.Entities.Catalog;
using AutoMapper;

namespace SIDCSupplyChain.Application.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsCachedResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsResponse, Product>().ReverseMap();
        }
    }
}