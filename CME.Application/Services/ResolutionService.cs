using AutoMapper;
using CME.Core;
using CME.EntityFramework;
using CME.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CME.Application.Services
{
   public class ResolutionService : IResolutionService
    {

        private readonly ResolutionDBContext context;
        private readonly IMapper mapper;

        public ResolutionService(ResolutionDBContext context, IMapper mapper) {
            this.context = context;
            this.mapper = mapper;
        }

       async Task<List<ResolutionTypesVM>> IResolutionService.GetResolutionTypes()
        {
            var resolutionTypesList=await this.context.ResolutionTypes.ToListAsync();

            return this.mapper.Map<List<ResolutionTypes>, List<ResolutionTypesVM>>(resolutionTypesList);
        }
    }
}
