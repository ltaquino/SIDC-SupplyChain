using SIDCSupplyChain.Infrastructure.Identity.Models;
using SIDCSupplyChain.Web.Areas.Admin.Models;
using AutoMapper;

namespace SIDCSupplyChain.Web.Areas.Admin.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>().ReverseMap();
        }
    }
}