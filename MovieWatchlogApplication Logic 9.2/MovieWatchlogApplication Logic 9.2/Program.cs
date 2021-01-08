using System;
using System.Collections.Generic;

namespace MovieWatchlogApplication_Logic_9._2
{
    class Program
    {
        static List<Movie> movies = new List<Movie>();
        static void Main(string[] args)
        {
         

            while (true)
            {
                Console.WriteLine("\n\r\n\rMovie Watchlog\n==============");
                Console.WriteLine("1) Add a Movie\n" +
                                  "2) Delete a Movie\n" +
                                  "3) Show Report\n" +
                                  "4) Load Database\n" +
                                  "5) Save Database\n" +
                                  "6) Quit");
                Console.Write("Input: ");
                var userChoice = Convert.ToInt32(Console.ReadLine());
                
                if (userChoice == 1)
                {
                    AddMovie();
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("\n\rDelete a Movie");

                }
                else if (userChoice == 3)
                {
                    ShowReport();
                }
                else if (userChoice == 4)
                {
                    Console.WriteLine("\n\rLoad database");
                }
                else if (userChoice == 5)
                {
                    Console.WriteLine("\n\rSave database");
                }
                else if (userChoice == 6)
                {
                    Console.Write("\n\r");
                    break;
                }
                else
                {
                    Console.WriteLine("\nUnknown command");
                }
            }
        }

        private static void AddMovie()    
        {
            // Add a Movie:
            // Name:Blade Runner
            // Length (min):117
            // Year:1982
            Console.Write("\n\rAdd a Movie:");
            Console.Write("\nName:");
            String name = Console.ReadLine();
            Console.Write("Length (min):");
            int length =  Convert.ToInt32(Console.ReadLine());
            Console.Write("Year:");
            int year = Convert.ToInt32(Console.ReadLine());
            movies.Add(new Movie( name, length, year));
        }

        private static void ShowReport()
        {
            int totalMovies = 0;
            int totalMinutes = 0;
            foreach (var movie in movies)
            {
                totalMovies++;
                totalMinutes = totalMinutes + movie.Length;
                if (totalMovies >= 2)
                {
                    Console.WriteLine(movie.Name + " (" + movie.Year + "), " + movie.Length + " minutes.  ");
                }
                else {
                    Console.WriteLine("\n\r" + movie.Name + " (" + movie.Year + "), " + movie.Length + " minutes.  ");
                }
            }

            Console.Write("\n\rTotal of " + totalMovies + " movies and " + totalMinutes + " minutes.\n");
        }
    }
}
//


[Serializable]
public class Movie
{
    public string Name;
    public int Length;
    public int Year;
    public Movie(string name, int length, int year)
    {
        Name = name;
        Length = length;
        Year = year;
    }

}
