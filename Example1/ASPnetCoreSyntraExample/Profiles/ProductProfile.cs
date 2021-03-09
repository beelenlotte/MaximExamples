using ASPnetCoreSyntraExample.DTO;
using ASPnetCoreSyntraExample.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ASPnetCoreSyntraExample.Controllers.CategoryController;

namespace ASPnetCoreSyntraExample.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductDTO, Product>()
                       .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Naam))
                       .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Prijs))
                       .ForMember(dest => dest.HiddenCode, opt => opt.MapFrom(src => src.VerbogenCode))
                       .ReverseMap();
            CreateMap<ResponseProductDTO, Product>().ReverseMap();

        }
    }
}
