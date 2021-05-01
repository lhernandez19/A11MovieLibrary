using System;
using System.Linq;
using A11MovieLibrary.Context;
using A11MovieLibrary.DataModels;
using A11MovieLibrary.Menus;

namespace A11MovieLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            var menu = new Menu();
            menu.DisplayMenu();


            //DISPLAY
            // using (var db = new MovieContext())
            // {
            //     var genres = db.Genres;
            //     foreach (var genre in genres)
            //     {
            //         System.Console.WriteLine($"{genre.Id} {genre.Name}");
            //     }
            // }

            //SEARCH
            // using(var db = new MovieContext())
            // {
            //     var foundGenre = db.Genres.Where(g => g.Name.Contains("W"))
            //     .FirstOrDefault();

            //     System.Console.WriteLine($"Genre found is: {foundGenre.Name}");
            // }


            // // UPDATE
            // using (var db = new MovieContext())
            // {
            //     var foundGenre = db.Genres.Where(g => g.Name == "War Games 2")
            //      .FirstOrDefault();


            //     var genre = new Genre() // not need it
            //     {
            //         Id = 17,
            //         Name = "War Games"
            //     };

            //     db.Genres.Update(genre);
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
