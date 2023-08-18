using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AeC.Domain.Dto;
using AutoMapper;

namespace AeC.Application.Mapper
{
    public class AeroportoClimaMapperDto : Profile
    {
        public AeroportoClimaMapperDto()
        {
            CreateMap<Domain.Models.AeroportoClima, AeroportoClimaDto>().ReverseMap();
        }
    }
}