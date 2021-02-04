using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3.Models
{
    public class MovieStorage
    {
        private static List<Movies> newMovies = new List<Movies>();

        public static IEnumerable<Movies> Movies => newMovies;

        public static void addMovie(Movies movie)
        {
            newMovies.Add(movie);
        }
    }
}
