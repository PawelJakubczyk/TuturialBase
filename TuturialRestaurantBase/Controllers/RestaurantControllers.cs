using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using TuturialRestaurantBase.Data;
using TutorialRestaurantBase.Entities;

namespace TuturialWebApi.Controllers;


[Route("api/[controller]")]
[ApiController]
public class RestaurantController(IRestaurantContext restaurantContext) : ControllerBase
{

    private readonly IRestaurantContext _restaurantContext = restaurantContext;


    [HttpGet]
    public async Task<IEnumerable<Restaurant>> GetAllResturants()
    {
        return  await _restaurantContext.Restaurants.Find(FilterDefinition<Restaurant>.Empty).ToListAsync();
    }




    //[HttpGet("max/{max}")]
    //public async Task<IEnumerable<Movie>> GetMaxMovies([FromRoute]int max, [FromQuery]int take)

    //{
    //    // Download up to 'max' videos from the database
    //    var movies = await _movieContext.Movies
    //    .Find(FilterDefinition<Movie>.Empty)
    //    .Limit(max)
    //    .ToListAsync();

    //    // Return the first 'take' of videos from the list
    //    return movies.Take(take);

    //}

    //[HttpGet("Greeting/{id}")]
    //public async Task<ActionResult<Movie>> GetGreetingWitTitleById([FromRoute]string id)
    //{
    //    var filter = Builders<Movie>.Filter.Eq(x => x.Id, id);
    //    var movie = await _movieContext.Movies.Find(filter).FirstOrDefaultAsync();
    //    return StatusCode(201, $"Hello {movie.Title}");
    //}


    //[HttpGet("{id}")]
    //public async Task<ActionResult<Movie?>> GetMovieById(string id)
    //{
    //    var filter = Builders<Movie>.Filter.Eq(x => x.Id, id);
    //    var movie = await _movieContext.Movies.Find(filter).FirstOrDefaultAsync();
    //    return movie is not null ? Ok(movie) : NotFound();
    //}

    //[HttpGet("title/{title}")]
    //public async Task<ActionResult<Movie?>> GetMovieByTitle(string title)
    //{
    //    var filter = Builders<Movie>.Filter.Eq(x => x.Title, title);
    //    var movie = await _movieContext.Movies.Find(filter).FirstOrDefaultAsync();
    //    return movie is not null ? Ok(movie) : NotFound();
    //}

    //[HttpGet("length")]
    //public async Task<ActionResult<Movie?>> GetMovieByTitleLength([FromBody] LengthRequestDto rangeLength, [FromQuery] int take)
    //{

    //    var min = rangeLength.MinLength;
    //    var max = rangeLength.MaxLength;

    //    var filter = Builders<Movie>.Filter.And(
    //        Builders<Movie>.Filter.Where(x => x.Title.Length >= min),
    //        Builders<Movie>.Filter.Where(x => x.Title.Length <= max)
    //    );

    //    if (min <= 0)
    //    {
    //        return BadRequest("Minimum length must be greater than 0.");
    //    }

    //    if (min >= max)
    //    {
    //        return BadRequest("Minimum length must be less than maximum length.");
    //    }

    //    var movies = await _movieContext.Movies.Find(filter).Limit(take).ToListAsync();

    //    return Ok(movies);
    //}


    //[HttpPost]
    //public async Task<ActionResult> CreateNewMovie(Movie movie)
    //{
    //    await _movieContext.Movies.InsertOneAsync(movie);
    //    return CreatedAtAction(nameof(GetMovieById), new { id = movie.Id }, movie);
    //}

    //[HttpPut("{id}")]
    //public async Task<ActionResult> UpdateMovie(string id, Movie updatedMovie)
    //{
    //    var filter = Builders<Movie>.Filter.Eq(x => x.Id, id);
    //    var result = await _movieContext.Movies.ReplaceOneAsync(filter, updatedMovie);
    //    return result.ModifiedCount > 0 ? Ok() : NotFound();
    //}

    //[HttpDelete("{id}")]
    //public async Task<ActionResult> DeleteMovie(string id)
    //{
    //    var filter = Builders<Movie>.Filter.Eq(x => x.Id, id);
    //    var result = await _movieContext.Movies.DeleteOneAsync(filter);
    //    return result.DeletedCount > 0 ? Ok() : NotFound();
    //}
}