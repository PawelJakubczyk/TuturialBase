using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using TuturialWebApi.Data;
using TuturialWebApi.Entieties;

namespace TuturialWebApi.Controllers;

//[Route("api/[controller]")]
//[ApiController]
//public class MovieController : ControllerBase
//{
//    private readonly IMongoCollection<Movie> _movies;

//    public MovieController(MongoDbService mongoDbService)
//    {
//        _movies = mongoDbService.Database.GetCollection<Movie>("movies");
//    }

//    [HttpGet]
//    public async Task<IEnumerable<Movie>> GetAllMovies()
//    {
//        return await _movies.Find(FilterDefinition<Movie>.Empty).ToListAsync();
//    }

//    [HttpGet("{id}")]
//    public async Task<ActionResult<Movie?>> GetMovieById(string id)
//    {
//        var filter = Builders<Movie>.Filter.Eq(x => x.Id, id);
//        var movie = _movies.Find(filter).FirstOrDefault();
//        return movie is not null ? Ok(movie) : NotFound();
//    }

//    [HttpPost]
//    public async Task<ActionResult> CreateNewMovie(Movie movie)
//    {
//        await _movies.InsertOneAsync(movie);
//        return CreatedAtAction(nameof(GetMovieById), new { id = movie.Id }, movie);
//    }

//    [HttpPut("{id}")]
//    public async Task<ActionResult> UpdateMovie(string id, Movie updatedMovie)
//    {
//        var filter = Builders<Movie>.Filter.Eq(x => x.Id, id);
//        var result = await _movies.ReplaceOneAsync(filter, updatedMovie);
//        return result.ModifiedCount > 0 ? Ok() : NotFound();
//    }

//    [HttpDelete("{id}")]
//    public async Task<ActionResult> DeleteMovie(string id)
//    {
//        var filter = Builders<Movie>.Filter.Eq(x => x.Id, id);
//        var result = await _movies.DeleteOneAsync(filter);
//        return result.DeletedCount > 0 ? Ok() : NotFound();
//    }
//}


[Route("api/[controller]")]
[ApiController]
public class MovieController : ControllerBase
{
    private readonly IMongoCollection<Movie> _movies;
    private readonly MongoDbService<Movie> _dbServise;

    public MovieController(MongoDbService<Movie> mongoDbService)
    {
        _dbServise = mongoDbService;
        _movies = _dbServise.GetCollection;
    }

    [HttpGet]
    public async Task<IEnumerable<Movie>> GetAllMovies()
    {
        return await _movies.Find(FilterDefinition<Movie>.Empty).ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Movie?>> GetMovieById(string id)
    {
        var filter = Builders<Movie>.Filter.Eq(x => x.Id, id);
        var movie = await _movies.Find(filter).FirstOrDefaultAsync();
        return movie is not null ? Ok(movie) : NotFound();
    }

    [HttpGet("title/{title}")]
    public async Task<ActionResult<Movie?>> GetMovieByTitle(string title)
    {
        var filter = Builders<Movie>.Filter.Eq(x => x.Title, title);
        var movie = await _movies.Find(filter).FirstOrDefaultAsync();
        return movie is not null ? Ok(movie) : NotFound();
    }


    [HttpPost]
    public async Task<ActionResult> CreateNewMovie(Movie movie)
    {
        await _movies.InsertOneAsync(movie);
        return CreatedAtAction(nameof(GetMovieById), new { id = movie.Id }, movie);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateMovie(string id, Movie updatedMovie)
    {
        var filter = Builders<Movie>.Filter.Eq(x => x.Id, id);
        var result = await _movies.ReplaceOneAsync(filter, updatedMovie);
        return result.ModifiedCount > 0 ? Ok() : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteMovie(string id)
    {
        var filter = Builders<Movie>.Filter.Eq(x => x.Id, id);
        var result = await _movies.DeleteOneAsync(filter);
        return result.DeletedCount > 0 ? Ok() : NotFound();
    }
}