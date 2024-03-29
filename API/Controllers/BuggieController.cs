using System;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggieController : BaseApiController
    {
        [HttpGet("not-found")]
        
        public ActionResult GetNotFound()
        {
            return NotFound();
        }
        [HttpGet("bad-request")]
        public ActionResult GetBadRequest()
        {
            return BadRequest(new ProblemDetails{Title = "this is a bad request"});
        }
        [HttpGet("unauthorised")]
        public ActionResult GetUnathorized()
        {
            return Unauthorized();
        }
        [HttpGet("validation-error")]
        public ActionResult GetValiadtionError()
        {
            ModelState.AddModelError("Problem1", "This is the first error");
            ModelState.AddModelError("Problem2", "This is the second error");
            return ValidationProblem();
        }
        [HttpGet("server-error")]
        public ActionResult GetServerError()
        {
            throw new Exception("this is a server error");
        }
    }
}