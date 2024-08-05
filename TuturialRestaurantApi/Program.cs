using TutorialWebApi.Services;
using TuturialRestaurantApi.Application.Middleware;
using TuturialRestaurantApi.Persistence.DataContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register application services
builder.Services.AddSingleton<IRestaurantContext, RestaurantContext>();
builder.Services.AddScoped<RestaurantService>();

// Register MediatR services
builder.Services.AddMediatR(options =>
{
    options.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

// Register custom middleware as a scoped service
builder.Services.AddScoped<ErrorHandlingMiddleware>();
builder.Services.AddScoped<ErrorHandlingMiddleware2>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use HTTPS redirection middleware
app.UseHttpsRedirection();

// Use authorization middleware
app.UseAuthorization();

// Use custom error handling middleware
app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseMiddleware<ErrorHandlingMiddleware2>();

// Map controllers to the pipeline
app.MapControllers();

app.Run();
