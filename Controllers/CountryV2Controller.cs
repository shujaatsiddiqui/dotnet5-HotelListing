using HotelListing.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Controllers
{
    /// <summary>
    /// here define api version
    /// it would only be called when api-version is explicitly passed in header
    /// </summary>
    [ApiVersion("2.0", Deprecated = true)]
    [Route("api/country")]
    [ApiController]
    public class CountryV2Controller : ControllerBase
    {
        private DatabaseContext _context;

        public CountryV2Controller(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCountries()
        {
            OkObjectResult result = Ok(_context.Countries);
            return await Task.FromResult<OkObjectResult>(result);
        }
    }
}