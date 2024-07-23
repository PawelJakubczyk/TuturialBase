using TutorialWebApi.Services;
using TuturialRestaurantApi.Data;

namespace TuturialRestaurantApi;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IRestaurantContext, RestaurantContext>();
        services.AddScoped<RestaurantService>();
        services.AddControllers();
        // other services
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // configure middleware
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
