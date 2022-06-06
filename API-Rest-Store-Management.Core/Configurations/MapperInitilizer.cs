using API_Rest_Store_Management.Core.DTOs;
using API_Rest_Store_Management.Data;
using AutoMapper;

namespace API_Rest_Store_Management.Core.Configurations
{
    public class MapperInitilizer : Profile
    {
        public MapperInitilizer()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Product, CreateProductDTO>().ReverseMap();
            CreateMap<Product, UpdateProductDTO>().ReverseMap();
            CreateMap<Store, StoreDTO>().ReverseMap();
            CreateMap<Store, CreateStoreDTO>().ReverseMap();
            CreateMap<Store, UpdateStoreDTO>().ReverseMap();
            CreateMap<ApiUser, UserDTO>().ReverseMap();
        }
    }
}