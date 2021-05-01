// namespace A11MovieLibrary.Data
// {
//     public class MovieRepository : IRepository
//     {
//         public void Add(Movie movie)
//         {

//         }

//         public void GetAll()
//         {
//             using (var db = new MovieContext())
//             {
//                 var genres = db.Genres;
//                 foreach (var genre in genres)
//                 {
//                     System.Console.WriteLine($"{genre.Id} {genre.Name}");
//                 }
//             }
//         }

//         public List<Movie> Search(string title)
//         {

//         }
//     }
// }