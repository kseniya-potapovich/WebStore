﻿using AutoMapper;
using Store.Dto;
using Store.Entities;

namespace Store.Mappings
{
    public class CategoryProfile: Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
        }
    }
}
