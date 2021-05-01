using System;
using System.Linq;
using A11MovieLibrary.Context;

namespace A11MovieLibrary.Menus
{
    public class Menu
    {
        public Menu(){}

        public void DisplayMenu()
        {
            string menuSelection;
            ActionMenu();
            menuSelection = Console.ReadLine();

            switch (menuSelection)
            {
                case "1": // Search movie
                Search();
                break;
                case "2": // Add movie
                Add();
                break;
                case "3": // Update movie
                Update();
                break;
                case "4": // Delete movie
                Delete();
                break;
            }



        }
        
        public void Search()
        {
            System.Console.Write("\nSearch by movie title: ");
            string mTitle = Console.ReadLine().ToLower();

            using(var db = new MovieContext())
            {
                var foundMovie = db.Movies.Where(m => m.Title.Contains(mTitle))
                .FirstOrDefault();

                System.Console.WriteLine($"Movie title found is: {foundMovie.Title}");
            }
        }

        public void Add()
        {

        }

        public void Update()
        {
            System.Console.Write("\nUpdate movie title: ");
            string mTitle = Console.ReadLine().ToLower();

        }

        public void Delete()
        {

        }




        public void ActionMenu()
        {
            Console.WriteLine("\nMake a selection\n");
            Console.WriteLine("1. Search movie");
            Console.WriteLine("2. Add movie");
            Console.WriteLine("3. Update movie");
            Console.WriteLine("4. Delete movie");
            Console.WriteLine("5. Exit\n");
        }
    }
}