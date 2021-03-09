using ASPnetCoreSyntraExample.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ASPnetCoreSyntraExample.Controllers.CategoryController;

namespace ASPnetCoreSyntraExample.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<ResponseCategoryWithProductsDTO, Category>().ReverseMap();
        }
    }
}
