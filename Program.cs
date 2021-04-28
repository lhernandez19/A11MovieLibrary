using System;
using System.Linq;
using A11MovieLibrary.Context;
using A11MovieLibrary.DataModels;

namespace A11MovieLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            //DISPLAY
            using (var db = new MovieContext())
            {
                var genres = db.Genres;
                foreach (var genre in genres)
                {
                    System.Console.WriteLine($"{genre.Id} {genre.Name}");
                }
            }

            // // UPDATE
            // using (var db = new MovieContext())
            // {
            //     var genre = new Genre()
            //     {
            //         Id = 17,
            //         Name = "War Games"
            //     };

            //     db. Genres.Update(genre);
            //     db.SaveChanges();
            // }       

            // // DELETE  
            // using (var db = new MovieContext())
            // {
            //     var foundGenre = db.Genres.Where(g => g.Name == "War Games 2"); // 

            //     var genre = new Genre()
            //     {
            //         Id = 17,
            //     };

            //     db. Genres.Remove(foundGenre);
            //     db.SaveChanges();
            // }  

            Console.WriteLine("Thanks for using the Movie Library!");
        }
    }
}
