using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AeC.Domain.Dto;
using AeC.Domain.ValueObjects;
using AutoMapper;

namespace AeC.Application.Mapper
{
    public class ClimaInfoMapperDto : Profile
    {
        public ClimaInfoMapperDto()
        {
            CreateMap<Domain.Models.CidadeClima, ClimaInfoDto>().ReverseMap();
        }
    }
}