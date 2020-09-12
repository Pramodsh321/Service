using Microsoft.Extensions.DependencyInjection;
using System;
using AutoMapper;
using CME.Application.ModelMapper;

namespace CME.module
{
    public static class AutoMapperModule
    {

        public static IServiceCollection ConfigureAutomapper(this IServiceCollection service)
        {

            var mappingConfig = new MapperConfiguration(mc =>
              {
                  mc.AddProfile(new MappingProfile());
              });
            IMapper mapper = mappingConfig.CreateMapper();
            service.AddSingleton(mapper);
            return service;
        }

    }
}
