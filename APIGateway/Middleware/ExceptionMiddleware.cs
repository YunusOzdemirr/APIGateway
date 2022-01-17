using System;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;

namespace APIGateway.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _requestDelegate;

        public ExceptionMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _requestDelegate.Invoke(context);
            }
            catch (Exception ex)
            {
                var RequestResult = new
                {
                    Message = ex.Message,
                    ApiUrl = context.Request.GetDisplayUrl(),
                    StatusCode = context.Response.StatusCode
                };
                var result = JsonSerializer.Serialize(RequestResult);
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(result);
            }
        }
    }
}

