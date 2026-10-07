using ComicBookGallery.Models;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Index()
        {
            var comicBooks = new ComicBook[]
            {
        new ComicBook
        {
            Id = 1,
            SeriesTitle = "The Amazing Spider-Man",
            IssueNumber = 700,
            DescriptionHtml = "Final issue!"
        },
        new ComicBook
        {
            Id = 2,
            SeriesTitle = "Batman",
            IssueNumber = 1,
            DescriptionHtml = "Batman comic book"
        }
            };

            return View(comicBooks);
        }

        public ActionResult Detail()
        {
            ComicBook comicBook = new ComicBook
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "Final issue!",
                Favorite = false,
                Artists = new Artist[0]
            };

            return View(comicBook);
        }
    }
}