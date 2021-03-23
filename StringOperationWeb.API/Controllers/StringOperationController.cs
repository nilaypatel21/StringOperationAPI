using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Core.BusinessServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringOperationWeb.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class StringOperationController : ControllerBase
    {
        private IStringOperationService stringOperationService;

        public StringOperationController(IStringOperationService _stringOperationService)
        {
            stringOperationService = _stringOperationService;
        }

        /// <summary>
        /// Validate if specified string has atleast one letter of each alphabate.
        /// </summary>
        /// <param name="inputString">Enter any string</param> 
        /// <response code="204">If string is not specifed then api will return 
        /// HTTP Status Code : 204 (No content)
        /// </response>
        /// <response code="200">If string is specified then api will validate string 
        /// and return true/false with HTTP Status Code : 200 (OK)
        /// </response>
        /// <remarks>
        /// Sample Request:
        /// GET /api/StringOperation/hasAlphabates?inputString=abcdefghijklmnopqrstuvwxy!@#$%$###Z
        /// </remarks>
        [HttpGet]
        [Route("hasAlphabates")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces("application/json")]
        public IActionResult HasAlphabates(string inputString)
        {
            var serviceResponse = stringOperationService.HasAllLettersOfAlphabet(inputString);

            if (serviceResponse.IsValidationFailed)
            {
                return NoContent();
            }

            return Ok(serviceResponse.Response);
        }
    }
}
