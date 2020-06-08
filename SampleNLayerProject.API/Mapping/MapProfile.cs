using AutoMapper;
using SampleNLayerProject.API.DTOs;
using SampleNLayerProject.Core.Entities;

namespace SampleNLayerProject.API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryS>();
            CreateMap<CategoryS, Category>();
            CreateMap<Category, CategoryL>();
            CreateMap<CategoryL, Category>();

            CreateMap<Product, ProductS>();
            CreateMap<ProductS, Product>();
        }
    }
}