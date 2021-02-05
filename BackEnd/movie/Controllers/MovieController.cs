using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;


[ApiController]
[Route("Movies")]
public class MovieController : ControllerBase
{
    private readonly IRepository<Movie> _movieRepository;

    public MovieController(IRepository<Movie> movieRepository)
    {
        _movieRepository = movieRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        //return _movieRepository.GetAll();
        try
        {
            var allMovies = await _movieRepository.GetAll();
            return Ok(allMovies);
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
            Console.WriteLine(error.StackTrace);
            
            //handle exception
            return NoContent();
        }
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> Get(long id)
    {
        try
        {
            var movie = await _movieRepository.Get(id);
            return Ok(movie);
        }
        catch (Exception)
        {
            //handle exception
            return NotFound($"no movie with id {id}");
        }  
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(long id)
    {
        try
        {
            await _movieRepository.Delete(id);
            return NoContent();
        }
        catch (Exception)
        {
            //handle exception
            return NotFound();
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(long id, [FromBody] Movie movie)
    {
        try
        {
            var editMovie = await _movieRepository.Update(new Movie { Id = id, Title = movie.Title, Description= movie.Description, Time1= movie.Time1, Time2= movie.Time2 });
            return Ok(editMovie);
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
            Console.WriteLine(error.StackTrace);
            //handle exception
            return NotFound("no movie updated");
        }  
    }

    [HttpPost]
    public async Task<IActionResult> Insert([FromBody] Movie movie)
    {
        try
        {
            var insertMovie = await  _movieRepository.Insert(movie);
            return Ok(insertMovie);
        }
        catch (Exception error)
        {   
            Console.WriteLine(error.Message);
            Console.WriteLine(error.StackTrace);
            //handle exception
            return NotFound("no movie found");
        }  
    }
    
}
