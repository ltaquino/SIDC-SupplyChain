using SIDCSupplyChain.Application.Features.Brands.Commands.Create;
using SIDCSupplyChain.Application.Features.Brands.Queries.GetAllCached;
using SIDCSupplyChain.Application.Features.Brands.Queries.GetById;
using SIDCSupplyChain.Domain.Entities.Catalog;
using AutoMapper;

namespace SIDCSupplyChain.Application.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<CreateBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsCachedResponse, Brand>().ReverseMap();
        }
    }
}