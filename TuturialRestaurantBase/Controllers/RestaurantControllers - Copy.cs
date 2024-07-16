//using Microsoft.AspNetCore.Mvc;
//using MongoDB.Driver;
//using TuturialRestaurantBase.Data;
//using TutorialRestaurantBase.Entities;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace TuturialWebApi.Controllers;


//[Route("api/[controller]")]
//[ApiController]
//public class RestaurantController : ControllerBase
//{
//    private readonly IRestaurantContext _restaurantContext;

//    public RestaurantController(IRestaurantContext restaurantContext)
//    {
//        _restaurantContext = restaurantContext;
//    }

//    // Get all restaurants
//    [HttpGet]
//    public async Task<IEnumerable<Restaurant>> GetAllRestaurants()
//    {
//        return await _restaurantContext.Restaurants.Find(FilterDefinition<Restaurant>.Empty).ToListAsync();
//    }

//    // Get restaurants by category
//    [HttpGet("category/{category}")]
//    public async Task<IEnumerable<Restaurant>> GetRestaurantsByCategory(string category)
//    {
//        var filter = Builders<Restaurant>.Filter.Eq(r => r.Category, category);
//        return await _restaurantContext.Restaurants.Find(filter).ToListAsync();
//    }

//    // Get restaurants by city
//    [HttpGet("city/{city}")]
//    public async Task<IEnumerable<Restaurant>> GetRestaurantsByCity(string city)
//    {
//        var filter = Builders<Restaurant>.Filter.Eq(r => r.Address.City, city);
//        return await _restaurantContext.Restaurants.Find(filter).ToListAsync();
//    }

//    // Get restaurants that offer delivery
//    [HttpGet("delivery")]
//    public async Task<IEnumerable<Restaurant>> GetRestaurantsWithDelivery()
//    {
//        var filter = Builders<Restaurant>.Filter.Eq(r => r.HasDelivery, true);
//        return await _restaurantContext.Restaurants.Find(filter).ToListAsync();
//    }

//    // Add a new restaurant
//    [HttpPost]
//    public async Task<IActionResult> AddRestaurant([FromBody] Restaurant restaurant)
//    {
//        await _restaurantContext.Restaurants.InsertOneAsync(restaurant);
//        return CreatedAtAction(nameof(GetRestaurantById), new { id = restaurant.Id }, restaurant);
//    }

//    // Update an existing restaurant
//    [HttpPut("{id}")]
//    public async Task<IActionResult> UpdateRestaurant(string id, [FromBody] Restaurant restaurant)
//    {
//        var filter = Builders<Restaurant>.Filter.Eq(r => r.Id, id);
//        var result = await _restaurantContext.Restaurants.ReplaceOneAsync(filter, restaurant);

//        if (result.ModifiedCount == 0)
//        {
//            return NotFound();
//        }

//        return NoContent();
//    }

//    // Delete a restaurant
//    [HttpDelete("{id}")]
//    public async Task<IActionResult> DeleteRestaurant(string id)
//    {
//        var filter = Builders<Restaurant>.Filter.Eq(r => r.Id, id);
//        var result = await _restaurantContext.Restaurants.DeleteOneAsync(filter);

//        if (result.DeletedCount == 0)
//        {
//            return NotFound();
//        }

//        return NoContent();
//    }

//    // Get a restaurant by ID
//    [HttpGet("{id}")]
//    public async Task<ActionResult<Restaurant>> GetRestaurantById(string id)
//    {
//        var filter = Builders<Restaurant>.Filter.Eq(r => r.Id, id);
//        var restaurant = await _restaurantContext.Restaurants.Find(filter).FirstOrDefaultAsync();

//        if (restaurant == null)
//        {
//            return NotFound();
//        }

//        return restaurant;
//    }
//}






//    //[HttpGet("max/{max}")]
//    //public async Task<IEnumerable<Movie>> GetMaxMovies([FromRoute]int max, [FromQuery]int take)

//    //{
//    //    // Download up to 'max' videos from the database
//    //    var movies = await _movieContext.Movies
//    //    .Find(FilterDefinition<Movie>.Empty)
//    //    .Limit(max)
//    //    .ToListAsync();

//    //    // Return the first 'take' of videos from the list
//    //    return movies.Take(take);

//    //}

//    //[HttpGet("Greeting/{id}")]
//    //public async Task<ActionResult<Movie>> GetGreetingWitTitleById([FromRoute]string id)
//    //{
//    //    var filter = Builders<Movie>.Filter.Eq(x => x.Id, id);
//    //    var movie = await _movieContext.Movies.Find(filter).FirstOrDefaultAsync();
//    //    return StatusCode(201, $"Hello {movie.Title}");
//    //}


//    //[HttpGet("{id}")]
//    //public async Task<ActionResult<Movie?>> GetMovieById(string id)
//    //{
//    //    var filter = Builders<Movie>.Filter.Eq(x => x.Id, id);
//    //    var movie = await _movieContext.Movies.Find(filter).FirstOrDefaultAsync();
//    //    return movie is not null ? Ok(movie) : NotFound();
//    //}

//    //[HttpGet("title/{title}")]
//    //public async Task<ActionResult<Movie?>> GetMovieByTitle(string title)
//    //{
//    //    var filter = Builders<Movie>.Filter.Eq(x => x.Title, title);
//    //    var movie = await _movieContext.Movies.Find(filter).FirstOrDefaultAsync();
//    //    return movie is not null ? Ok(movie) : NotFound();
//    //}

//    //[HttpGet("length")]
//    //public async Task<ActionResult<Movie?>> GetMovieByTitleLength([FromBody] LengthRequestDto rangeLength, [FromQuery] int take)
//    //{

//    //    var min = rangeLength.MinLength;
//    //    var max = rangeLength.MaxLength;

//    //    var filter = Builders<Movie>.Filter.And(
//    //        Builders<Movie>.Filter.Where(x => x.Title.Length >= min),
//    //        Builders<Movie>.Filter.Where(x => x.Title.Length <= max)
//    //    );

//    //    if (min <= 0)
//    //    {
//    //        return BadRequest("Minimum length must be greater than 0.");
//    //    }

//    //    if (min >= max)
//    //    {
//    //        return BadRequest("Minimum length must be less than maximum length.");
//    //    }

//    //    var movies = await _movieContext.Movies.Find(filter).Limit(take).ToListAsync();

//    //    return Ok(movies);
//    //}


//    //[HttpPost]
//    //public async Task<ActionResult> CreateNewMovie(Movie movie)
//    //{
//    //    await _movieContext.Movies.InsertOneAsync(movie);
//    //    return CreatedAtAction(nameof(GetMovieById), new { id = movie.Id }, movie);
//    //}

//    //[HttpPut("{id}")]
//    //public async Task<ActionResult> UpdateMovie(string id, Movie updatedMovie)
//    //{
//    //    var filter = Builders<Movie>.Filter.Eq(x => x.Id, id);
//    //    var result = await _movieContext.Movies.ReplaceOneAsync(filter, updatedMovie);
//    //    return result.ModifiedCount > 0 ? Ok() : NotFound();
//    //}

//    //[HttpDelete("{id}")]
//    //public async Task<ActionResult> DeleteMovie(string id)
//    //{
//    //    var filter = Builders<Movie>.Filter.Eq(x => x.Id, id);
//    //    var result = await _movieContext.Movies.DeleteOneAsync(filter);
//    //    return result.DeletedCount > 0 ? Ok() : NotFound();
//    //}
////}