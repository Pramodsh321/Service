using CME.Application.Services;
using CME.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CME.module
{
   public static class DependencyModule
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection service, IConfiguration config)
        {

            service.AddDbContext<ResolutionDBContext>(options => options.UseSqlServer(config["ConnectionString:ResolutionDB"]));
            service.AddTransient<IResolutionService, ResolutionService>();
            return service;
        }

    }
}
