using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Stored.Application.Dtos;
using Api.Stored.Application.Dtos.Pacientes;
using Api.Stored.Core.Entities;
using AutoMapper;

namespace Api.Stored.Application.Mapper
{
    public class ProfilesMappers:Profile
    {
        public ProfilesMappers()
        {
            CreateMap<UserForRegistrationDto, User>()
            .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));

            CreateMap<PacientesResponseDto, TblCatPaciente>().ReverseMap();
        }
    }
}
