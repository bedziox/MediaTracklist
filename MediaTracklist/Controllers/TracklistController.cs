using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediaTracklist.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TracklistController : Controller
    {
        private readonly ILogger<TracklistController> _logger;
        public TracklistController(ILogger<TracklistController> logger)
        {
            this._logger = logger;
        }
    }
}
