using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        // This will take care of the mapping (product and productDto)
        public MappingProfiles()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
                .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.Name))
                // if its not resolved then we'll just going to concatenate the url with the path of the image check out the screen
                //.ForMember(d => d.PictureUrl, o => o.MapFrom<ProductUrlResolver>());
                .ForMember(d => d.PictureUrl, o => o.MapFrom(s => "https://localhost:5001/" + s.PictureUrl));
        }
    }
}