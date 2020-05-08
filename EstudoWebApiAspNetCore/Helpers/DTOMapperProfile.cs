using AutoMapper;
using EstudoWebApiAspNetCore.Models;
using EstudoWebApiAspNetCore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoWebApiAspNetCore.Helpers
{
    public class DTOMapperProfile: Profile
    {
        public DTOMapperProfile()
        {
            CreateMap<Palavra, PalavraDTO>();
        }
    }
}
