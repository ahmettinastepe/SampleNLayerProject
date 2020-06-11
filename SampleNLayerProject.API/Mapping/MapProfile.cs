using AutoMapper;
using SampleNLayerProject.API.DTOs;
using SampleNLayerProject.Core.Entities;
using System.Collections.Generic;

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

            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();
            CreateMap<OrderS, OrderDto>();
            CreateMap<OrderDto, OrderS>();
            CreateMap<OrderS, Order>();

            CreateMap<Solusyon, SolusyonDto>();
            CreateMap<SolusyonDto, Solusyon>();
            CreateMap<List<Solusyon>, List<SolusyonDto>>();
        }
    }
}