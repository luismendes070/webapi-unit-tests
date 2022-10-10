using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloAPI.Controllers
{
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [HttpGet("/error")]
        public IAction error()
        {
            var context = HttpContext.Feature.Get<IExceptionHandlerFeature>();
            var stackTrace = context.Error.StackTrace;
            var errorMessage = context.Error.Message;

            // log this error somewhere

            return Problem();

        }
    }
}