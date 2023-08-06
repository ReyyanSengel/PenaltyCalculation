using AutoMapper;
using PenaltyCalculation.Application.ViewModels;
using PenaltyCalculation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Application.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Registration,PreRegistrationViewModel>().ReverseMap();
            CreateMap<Registration,RegistrationViewModel>().ReverseMap();
            CreateMap<Registration,CalculateViewModel>().ReverseMap();
            CreateMap<Country,CountryViewModel>().ReverseMap();
        }
    }
}
