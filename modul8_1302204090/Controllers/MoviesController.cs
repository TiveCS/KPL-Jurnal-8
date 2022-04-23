using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modul8_1302204090.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MoviesController : ControllerBase
	{

		// Mendapatkan semua movie yang ada
		[HttpGet]
		public ActionResult<List<Movie>> GetMovies()
		{
			return Movie.Movies.ToList();
		}

		// Menambahkan sebuah movie
		[HttpPost]
		public ActionResult<Movie> AddMovie(Movie movie)
		{
			Movie.Movies.Add(movie);
			return Ok("Movie has been added");
		}

		// Mendapatkan satu objek movie
		[HttpGet]
		[Route("{id}")]
		public ActionResult<Movie> GetMovie(int id)
		{
			Movie movie = Movie.Movies[id];
			return Ok(movie);
		}

		// Menghapus sebuah movie dari database
		[HttpDelete]
		[Route("{id}")]
		public ActionResult DeleteMovie(int id)
		{
			Movie.Movies.Remove(Movie.Movies[id]);
			return Ok("Successfully delete movie");
		}

	}
}
