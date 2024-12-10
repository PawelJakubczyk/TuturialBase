using ASPEncyclopedia.Middleware;
using Microsoft.AspNetCore.Http;

namespace ASPEncyclopedia.Middleware;

public class MiddlewareExample1 : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            // Before passing the request to the next middleware
            Console.WriteLine("MiddlewareExample1 : Start Handling request");

            // Pass the request to the next middleware in the pipeline
            await next(context);

            // After the request has been processed by the subsequent middleware
            Console.WriteLine("MiddlewareExample1 : Finished handling request.");
        }
        catch (Exception ex)
        {
            // Handle any exceptions that occur in the middleware pipeline
            Console.WriteLine("An error occurred: " + ex.Message);
            context.Response.StatusCode = 500;
            await context.Response.WriteAsync("An unexpected error occurred.");
        }
    }
}

public class MiddlewareExample2 : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            // Before passing the request to the next middleware
            Console.WriteLine("MiddlewareExample2 : Start Handling request");

            // Pass the request to the next middleware in the pipeline
            await next(context);

            // After the request has been processed by the subsequent middleware
            Console.WriteLine("MiddlewareExample2 : Finished handling request.");
        }
        catch (Exception ex)
        {
            // Handle any exceptions that occur in the middleware pipeline
            Console.WriteLine("An error occurred: " + ex.Message);
            context.Response.StatusCode = 500;
            await context.Response.WriteAsync("An unexpected error occurred.");
        }
    }
}


/* 
 * Registration in Program
//Register custom middleware as a scoped service
builder.Services.AddScoped<MiddlewareExample1>();
builder.Services.AddScoped<MiddlewareExample2>();
...
//Use custom error handling middleware
app.UseMiddleware<MiddlewareExample1>();
app.UseMiddleware<MiddlewareExample2>(); 
*/

