using SIDCSupplyChain.Application.Features.Products.Commands.Create;
using SIDCSupplyChain.Application.Features.Products.Commands.Update;
using SIDCSupplyChain.Application.Features.Products.Queries.GetAllCached;
using SIDCSupplyChain.Application.Features.Products.Queries.GetById;
using SIDCSupplyChain.Web.Areas.Catalog.Models;
using AutoMapper;

namespace SIDCSupplyChain.Web.Areas.Catalog.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<GetAllProductsCachedResponse, ProductViewModel>().ReverseMap();
            CreateMap<GetProductByIdResponse, ProductViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, ProductViewModel>().ReverseMap();
            CreateMap<UpdateProductCommand, ProductViewModel>().ReverseMap();
        }
    }
}