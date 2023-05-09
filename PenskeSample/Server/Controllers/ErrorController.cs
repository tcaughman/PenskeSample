using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Emporos.Emporos.Pharmacy.Api.Controllers
{
	[Route("[controller]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        private readonly ILogger<ErrorController> _logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            _logger = logger;
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        [Route("/error-development")]
        public IActionResult HandleErrorDevelopment([FromServices] IHostEnvironment hostEnvironment)
        {
            if (!hostEnvironment.IsDevelopment())
            {
                return NotFound();
            }

            var exceptionHandler = HttpContext.Features.Get<IExceptionHandlerFeature>()!;
            int getHttpStatus = GetHttpStatusCode(exceptionHandler);
            _logger.LogError(exceptionHandler.Error, "Error while processing request " );
            return Problem(
                statusCode: getHttpStatus,
                detail: exceptionHandler.Error.StackTrace,
                title: exceptionHandler.Error.Message);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        [Route("/error")]
        public IActionResult HandleError()
        {
            var exceptionHandler = HttpContext.Features.Get<IExceptionHandlerFeature>()!;
            _logger.LogError(message: exceptionHandler.Error.StackTrace);
            int getHttpStatus = GetHttpStatusCode(exceptionHandler);
            return Problem(statusCode: getHttpStatus );
        }

        private static int GetHttpStatusCode(IExceptionHandlerFeature? exceptionHandlerFeature)
        {
            int getHttpStatus;
            const string httpStatusCodeField = "<StatusCode>k__BackingField";
            try
            {
                getHttpStatus = (int)exceptionHandlerFeature?.Error?.GetType().GetField(httpStatusCodeField, BindingFlags.NonPublic | BindingFlags.Instance)!.GetValue(exceptionHandlerFeature.Error)!;
            }
            catch (Exception)
            {                
                getHttpStatus = 500;
            }

            return getHttpStatus;
        }

    }
}
