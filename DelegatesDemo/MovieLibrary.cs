using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class MovieLibrary
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie() { title = "The Departed", runTime = 91},
                new Movie() { title = "Inception", runTime = 88 },
                new Movie() { title = "The Dark Knight", runTime = 92 }
            };
        }
    }
}
