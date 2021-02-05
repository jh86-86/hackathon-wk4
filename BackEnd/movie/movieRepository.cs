using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Threading.Tasks;

public class MovieRepository : BaseRepository, IRepository<Movie>
{
    public MovieRepository(IConfiguration configuration) : base(configuration) { }

    public async Task<IEnumerable<Movie>> GetAll()
    {
        using var connection = CreateConnection();
        IEnumerable<Movie> movies = await connection.QueryAsync<Movie>("SELECT * FROM Movies;");
        return movies;
    }


    public async Task Delete(long id)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("DELETE FROM Movies WHERE Id = @Id;", new { Id = id });
    }

    public async Task<Movie> Get(long id)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleAsync<Movie>("SELECT * FROM Movies WHERE Id = @Id;", new { Id = id });
    }

    public async Task<Movie> Update(Movie movie)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleAsync<Movie>("UPDATE Movies SET Title = @Title, Description = @Description, Time1= @Time1, Time2= @Time2 WHERE Id = @Id RETURNING *", movie);
    }

    public async Task<Movie> Insert(Movie movie)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleAsync<Movie>("INSERT INTO Movies (Title, Description,Time1,Time2) VALUES (@Title, @Description,@Time1, @Time2) RETURNING *;", movie);
    }
}
