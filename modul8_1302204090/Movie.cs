namespace modul8_1302204090
{
	public class Movie
	{

		// Pengganti Database
		public static List<Movie> Movies = new List<Movie>()
		{
			new Movie() { Title = "The Shawshank Redemption", Director = "Frank Darabont", Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", Stars = new List<string>(){  "Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler" } },
			new Movie() { Title = "The Godfather", Director = "Francis Ford Coppola", Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.", Stars = new List<string>(){ "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton" } },
			new Movie() { Title = "The Dark Knight", Director = "Christopher Nolan", Description = "TWhen the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", Stars = new List<string>(){ "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine" } },
			new Movie() { Title = "The Lord of the Rings: The Return of the King", Director = "Peter Jackson", Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", Stars = new List<string>(){ "Elijah Wood", "Viggo Mortensen", "Ian McKellen", "Orlando Bloom" } }
		};

		public string Title { get; set; }

		public string Director { get; set; }

		public List<string> Stars { get; set; }

		public string Description { get; set; }

		public Movie()
		{

		}
	}
}
