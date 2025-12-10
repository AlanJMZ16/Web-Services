using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers;

public class ErrorController : BaseApiController
{
    [HttpGet("bad-request")]
    public IActionResult GetBadRequest() // 400
    {
        // throw new Exception("Invalid request")  500
        //var inputParam = -1;
        //if (inputParam <= 0) throw new ArgumentOutOfRangeException(nameof(inputParam));
        
        return BadRequest("bad request");
    }

    [HttpGet("auth")]
    public IActionResult GetAuth() //401
    {
        return Unauthorized();
    }

    [HttpGet("not-found")]
    public IActionResult GetNotFound() //404
    {
        return NotFound();
    }

    [HttpGet("server-error")]
    public IActionResult GetServerError() // 500
    {
        throw new Exception("Server Error");
    }
}