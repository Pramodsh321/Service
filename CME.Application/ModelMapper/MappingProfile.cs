using AutoMapper;
using CME.Core;
using CME.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CME.Application.ModelMapper
{
   public class MappingProfile: Profile
    {

        public Mapper mapper;

        public MappingProfile() {

            CreateMap<ResolutionTypes, ResolutionTypesVM>();
        }
    }
}
