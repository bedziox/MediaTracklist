using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediaTracklist.Models;

namespace MediaTracklist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediumController : Controller
    {
        private readonly ILogger<MediumController> _logger;

        public MediumController(ILogger<MediumController> logger)
        {
            this._logger = logger;
        }
        [HttpGet]
        public async Task<ActionResult<List<Medium>>> Get()
        {
            return NotFound();
        }
    }
}
