using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Printer printer = new Printer();
            //printer.Execute();
            printer.TestDelegate();

            //*****************************************************************************************
            
            Calculator calculator = new Calculator();
            NewCalculator newCalculator = new NewCalculator();

            //calculator.PrintResult(10, 20, newCalculator.SetSum);

            //calculator.PrintResult(10, 20, calculator.MultiplyTwoNumbers);

            //*****************************************************************************************

            List<int> grades = new List<int>() { 100, 85, 97, 61, 55, 89 };
            IEnumerable<int> result = GradeChecker.CheckGrades(grades, GradeChecker.GreaterThanSeventy);
            foreach (int grade in result)
            {
                Console.WriteLine(grade);
            }

            //*****************************************************************************************

            MovieLibrary movieLibrary = new MovieLibrary();
            List<Movie> movies = movieLibrary.GetMovies();

            List<Movie> hourAndAHalfMovieRunTime = movies.FindAll(m => m.runTime > 90);
            foreach (var movie in hourAndAHalfMovieRunTime)
            {
                Console.WriteLine(movie.title);
            }

            //*****************************************************************************************

            //The Departed, Inception, The Dark Knight

            var ninetyMinuteMovies = movies.Where(m => m.runTime >= 90); //The Departed, The Dark Knight

            var moviesSorted = ninetyMinuteMovies.OrderBy(m => m.title); //The Dark Knight, The Departed

            var movieTitles = moviesSorted.Select(m => m.title); //"The Dark Knight", "The Departed"
            
        }


        //m => m.runTime > 90
        public bool CheckEachMovie(Movie m)
        {
            if(m.runTime > 90)
            {
                return true;
            }
            return false;
        }
    }
}
