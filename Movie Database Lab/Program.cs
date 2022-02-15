
using Movie_Database_Lab;
bool runProgram = true;
List<Movie> movies = new List<Movie>()
{
    new Movie("Seven Samurai","Action", 207, 1954),
    new Movie("Unforgiven", "Action", 190, 1992 ),
    new Movie("Blade Runner", "Sci-Fi", 117, 1982),
    new Movie("Lord of the Rings: The Two Towers", "Fantasy", 179, 2002),
    new Movie("Spirited Away", "Animated", 125, 2001),
    new Movie("Alien", "Sci-Fi", 117, 1979),
    new Movie("The Shining", "Horror", 146, 1980),
    new Movie("Dune", "Sci-Fi", 155, 2021),
    new Movie("Saving Private Ryan", "Drama", 169, 1998),
    new Movie("The Shawshank Redemption", "Drama", 144, 1994)
};



Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine($"There are {movies.Count} movies in this list.");

while (runProgram)
{

    Console.WriteLine($"What category are you interested in?");
    string userInput = Console.ReadLine();
    Movie m = new Movie();
    m.GetTitle(userInput, movies);
    runProgram = Validator.Validator.GetContinue();

}