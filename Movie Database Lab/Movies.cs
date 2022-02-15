using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database_Lab
{
    public class Movie
    {
        private string Title { get; set; }
        private string Category { get; set; }
        private int RunTime { get; set; }
        private int YearReleased { get; set; }

        public Movie(string _title, string _category, int _runTime, int _yearReleased)
        {
            Title = _title;
            Category = _category;
            RunTime = _runTime;
            YearReleased = _yearReleased;
        }

        public Movie()
        {
        }

        public void GetTitle(string userCatChoice, List<Movie> movies)
        {
                if(userCatChoice == "Action" || userCatChoice == "Drama" || userCatChoice == "Fantasy" || userCatChoice == "Sci-Fi" || userCatChoice == "Animated")
                {
                //Alphabetizing list by Title
                movies.Sort((x, y) => string.Compare(x.Title, y.Title));

                //Looping through list for matching category 
                foreach (Movie m in movies)
                    {
                        if (m.Category == userCatChoice)
                        {
                            Console.WriteLine($"{m.Title}  Run Time: {m.RunTime}min  Year Released: {m.YearReleased}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That category is not available.");
                }
        }
    }
}


