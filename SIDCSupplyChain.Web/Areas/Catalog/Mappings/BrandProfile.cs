using SIDCSupplyChain.Application.Features.Brands.Commands.Create;
using SIDCSupplyChain.Application.Features.Brands.Commands.Update;
using SIDCSupplyChain.Application.Features.Brands.Queries.GetAllCached;
using SIDCSupplyChain.Application.Features.Brands.Queries.GetById;
using SIDCSupplyChain.Web.Areas.Catalog.Models;
using AutoMapper;

namespace SIDCSupplyChain.Web.Areas.Catalog.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<GetAllBrandsCachedResponse, BrandViewModel>().ReverseMap();
            CreateMap<GetBrandByIdResponse, BrandViewModel>().ReverseMap();
            CreateMap<CreateBrandCommand, BrandViewModel>().ReverseMap();
            CreateMap<UpdateBrandCommand, BrandViewModel>().ReverseMap();
        }
    }
}