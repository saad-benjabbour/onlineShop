using API.Dtos;
using AutoMapper;
using Core.Entities;
using Microsoft.Extensions.Configuration;
using System;

namespace API.Helpers
{
    public class ProductUrlResolver : IValueResolver<Product, ProductDto, string>
    {
        private readonly IConfiguration _config;
        // Use the IConfiguration from Microsoft
        public ProductUrlResolver(IConfiguration config)
        {
            _config = config;
        }
        // This will solve the url value for the picture ulrs
        public string Resolve(Product source, ProductDto destination, string destMember, ResolutionContext context)
        {
            if(!string.IsNullOrEmpty(source.PictureUrl))
            {
                return _config["ApiUrl"] + source.PictureUrl;
            }
            // we sat up the product Url Image to not null 
            // so returning null is going to be a problem
            return null;
        }

    }
}