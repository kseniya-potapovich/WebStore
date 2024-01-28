using AutoMapper;
using Store.Dto;
using Store.Entities;

namespace Store.Mappings
{
    public class CartItemProfile: Profile
    {
        public CartItemProfile() 
        {
            CreateMap<CartItemDto, CartItem>().ReverseMap();
            CreateMap<CreateCartItemDto, CartItem>().ReverseMap();
        }
    }
}
