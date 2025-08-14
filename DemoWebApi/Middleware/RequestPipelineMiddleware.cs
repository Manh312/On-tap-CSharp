using DemoWebApi.Models;
using Serilog;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace DemoWebApi.Middleware
{
    public class RequestPipelineMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestPipelineMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Log.Information("Received request: {Method} {Path}", context.Request.Method, context.Request.Path);

            if (!context.Request.Path.StartsWithSegments("/api/products"))
            {
                Log.Warning("Invalid endpoint accessed: {Path}", context.Request.Path);
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsync("Invalid endpoint.");
                return;
            }

            if (context.Request.Method == HttpMethods.Post)
            {
                context.Request.EnableBuffering();
                var body = await new StreamReader(context.Request.Body).ReadToEndAsync();
                context.Request.Body.Position = 0;

                if (string.IsNullOrEmpty(body))
                {
                    Log.Warning("Empty request body for POST /api/products");
                    context.Response.StatusCode = StatusCodes.Status400BadRequest;
                    await context.Response.WriteAsync("Request body is required.");
                    return;
                }

                var request = JsonSerializer.Deserialize<ProductRequest>(body);
                if (request == null)
                {
                    Log.Warning("Invalid request format for POST /api/products");
                    context.Response.StatusCode = StatusCodes.Status400BadRequest;
                    await context.Response.WriteAsync("Invalid request format.");
                    return;
                }

                var validationContext = new ValidationContext(request);
                var validationResults = new List<ValidationResult>();
                if (!Validator.TryValidateObject(request, validationContext, validationResults, true))
                {
                    Log.Warning("Validation failed for POST /api/products: {Errors}", JsonSerializer.Serialize(validationResults));
                    context.Response.StatusCode = StatusCodes.Status400BadRequest;
                    await context.Response.WriteAsJsonAsync(validationResults);
                    return;
                }
                Log.Information("Validation passed for POST /api/products: {Request}", JsonSerializer.Serialize(request));
            }

            await _next(context);
        }
    }
    public static class RequestPipelineMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestPipeline(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestPipelineMiddleware>();
        }
    }
}
