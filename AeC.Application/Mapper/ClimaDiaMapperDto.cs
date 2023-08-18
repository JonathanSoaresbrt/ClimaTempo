using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AeC.Domain.Dto;
using AutoMapper;

namespace AeC.Application.Mapper
{
    public class ClimaDiaMapperDto : Profile
    {
        public ClimaDiaMapperDto()
        {
            CreateMap<Domain.Models.ClimaDia, ClimaDiaDto>().ReverseMap();
        }
    }
}