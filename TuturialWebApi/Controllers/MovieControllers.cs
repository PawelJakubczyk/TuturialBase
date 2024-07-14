using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using TuturialWebApi.Data;
using TuturialWebApi.Entieties;

namespace TuturialWebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieController(IMovieContext movieContext) : ControllerBase
{
    private readonly IMovieContext _movieContext = movieContext;

    [HttpGet]
    public async Task<IEnumerable<Movie>> GetAllMovies()
    {
        return await _movieContext.Movies.Find(FilterDefinition<Movie>.Empty).ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Movie?>> GetMovieById(string id)
    {
        var filter = Builders<Movie>.Filter.Eq(x => x.Id, id);
        var movie = await _movieContext.Movies.Find(filter).FirstOrDefaultAsync();
        return movie is not null ? Ok(movie) : NotFound();
    }

    [HttpGet("title/{title}")]
    public async Task<ActionResult<Movie?>> GetMovieByTitle(string title)
    {
        var filter = Builders<Movie>.Filter.Eq(x => x.Title, title);
        var movie = await _movieContext.Movies.Find(filter).FirstOrDefaultAsync();
        return movie is not null ? Ok(movie) : NotFound();
    }


    [HttpPost]
    public async Task<ActionResult> CreateNewMovie(Movie movie)
    {
        await _movieContext.Movies.InsertOneAsync(movie);
        return CreatedAtAction(nameof(GetMovieById), new { id = movie.Id }, movie);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateMovie(string id, Movie updatedMovie)
    {
        var filter = Builders<Movie>.Filter.Eq(x => x.Id, id);
        var result = await _movieContext.Movies.ReplaceOneAsync(filter, updatedMovie);
        return result.ModifiedCount > 0 ? Ok() : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteMovie(string id)
    {
        var filter = Builders<Movie>.Filter.Eq(x => x.Id, id);
        var result = await _movieContext.Movies.DeleteOneAsync(filter);
        return result.DeletedCount > 0 ? Ok() : NotFound();
    }
}