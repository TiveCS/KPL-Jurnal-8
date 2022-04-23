using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modul8_1302204090.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MoviesController : ControllerBase
	{

		[HttpGet]
		public IEnumerable<Movie> GetMovies()
		{
			List<Movie> movies = new List<Movie>();

			return movies;
		}

		[HttpPost]
		public void AddMovie(Movie movie)
		{

		}

		[HttpGet]
		[Route("{id}")]
		public Movie GetMovie(int id)
		{
			return null;
		}
		
		[HttpDelete]
		[Route("{id}")]
		public void DeleteMovie(int id)
		{

		}
	}
}
