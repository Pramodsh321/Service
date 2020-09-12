using CME.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CME.Application.Services
{
   public interface IResolutionService
    {
        Task<List<ResolutionTypesVM>> GetResolutionTypes();
    }
}
