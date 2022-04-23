using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modul8_1302204090.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MoviesController : ControllerBase
	{

		[HttpGet]
		public ActionResult<List<Movie>> GetMovies()
		{
			return Movie.Movies.ToList();
		}

		[HttpPost]
		public ActionResult<Movie> AddMovie(Movie movie)
		{
			Movie.Movies.Add(movie);
			return Ok("Movie has been added");
		}

		[HttpGet]
		[Route("{id}")]
		public ActionResult<Movie> GetMovie(int id)
		{
			Movie movie = Movie.Movies[id];
			return Ok(movie);
		}

		[HttpDelete]
		[Route("{id}")]
		public ActionResult DeleteMovie(int id)
		{
			Movie.Movies.Remove(Movie.Movies[id]);
			return Ok("Successfully delete movie");
		}

	}
}
