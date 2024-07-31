namespace TuturialRestaurantApi.Application.Middleware;

//// This middleware handles errors and logs the requests and responses
public class ErrorHandlingMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            // Before passing the request to the next middleware
            Console.WriteLine("Handling request: " + context.Request.Path);

            // Pass the request to the next middleware in the pipeline
            await next(context);

            // After the request has been processed by the subsequent middleware
            Console.WriteLine("Finished handling request.");
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

//// This middleware handles errors and logs the requests and responses
public class ErrorHandlingMiddleware2 : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            // Before passing the request to the next middleware
            Console.WriteLine("MIDLLEWARE2 Handling request: " + context.Request.Path);

            // Pass the request to the next middleware in the pipeline
            await next(context);

            // After the request has been processed by the subsequent middleware
            Console.WriteLine("MIDLLEWARE2 Finished handling request.");
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


class Rogal
{
    public void LogMe()
    {
        Console.WriteLine("I play Valheim");
    }
    public void PlayYkuza()
    {
        Console.WriteLine("I play Yakuza");
    }

    public void ProcessRequest()
    {
        //Complicated Logic
        Console.WriteLine("Processing");
    }

    public void RequestPipeline(List<Action> middleware, Action endpoint)
    {
        foreach (var action in middleware)
        {
            action();
        }
        endpoint();
    }
}