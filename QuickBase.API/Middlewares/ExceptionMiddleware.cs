using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using QuickBase.API.ApiModels;
using QuickBase.Business.Exceptions;
using Serilog;
using System;
using System.Net;
using System.Threading.Tasks;

namespace QuickBase.API.Middlewares
{
    /// <summary>Global exception middleware.</summary>
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        /// <summary>Initializes a new instance of the <see cref="ExceptionMiddleware" /> class.</summary>
        /// <param name="next">The next.</param>
        /// <param name="logger">The logger.</param>
        public ExceptionMiddleware(RequestDelegate next, ILogger logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                httpContext.Response.ContentType = "application/json";
                var errorModel = new ErrorModel();
                switch (ex)
                {
                    case ValidationException customEx:
                        httpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                        errorModel.StatusCode = (int)HttpStatusCode.BadRequest;
                        errorModel.Message = $"{customEx.Entity} validation error.";
                        break;
                    default:
                        httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        errorModel.StatusCode = (int)HttpStatusCode.InternalServerError;
                        errorModel.Message = $"Unknown exception. Please contact the administrator";
                        break;
                }
                _logger.Error(ex, errorModel.Message);

                var errMessageStr = JsonConvert.SerializeObject(errorModel);

                await httpContext.Response.WriteAsync(errMessageStr);
            }
        }
    }
}
