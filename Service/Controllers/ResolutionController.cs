using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CME.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResolutionController : ControllerBase
    {

        private readonly IResolutionService resolutionService;

        public ResolutionController(IResolutionService resolutionService) {
            this.resolutionService = resolutionService;
        }


        // GET api/values
        [HttpGet]
        [Route("Types")]
        public async Task<IActionResult> Get()
        {
            var resolutionTypes= await this.resolutionService.GetResolutionTypes();

            return Ok(resolutionTypes);
        }

    }
}
