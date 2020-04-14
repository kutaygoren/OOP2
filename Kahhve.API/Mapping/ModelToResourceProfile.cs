using AutoMapper;
using Kahhve.API.Domain.Models;
using Kahhve.API.Extensions;
using Kahhve.API.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kahhve.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement,
                           opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));
        }
    }
}
