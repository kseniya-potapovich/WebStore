using AutoMapper;
using Store.Dto;
using Store.Entities;

namespace Store.Mappings
{
    public class UserProfile: Profile
    {
        public UserProfile() 
        { 
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, CreateUserDto>().ReverseMap();
            CreateMap<LoginDto, LoginDto>().ReverseMap();
        }
    }
}
