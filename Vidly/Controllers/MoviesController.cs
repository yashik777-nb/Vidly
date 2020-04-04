using Microsoft.Ajax.Utilities;
using System;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "KGF" };

            //return View(movie); // View method in Controller class
            // return new ViewResult (movie); another way of sending data to view

            // return Content("Hello World");
            // return HttpNotFound();
            // return new EmptyResult();

            return RedirectToAction("Index", "Home", new { page=1, sort="name" }); // Action , Controller

            // 1. ViewResult -> HelperMethod: View() -> To return a view.
            // 1. ParitalViewResult -> HelperMethod: PartialView() -> To return a partial view.
            // 1. ContentResult -> HelperMethod: Content() -> To return simple text.
            // 1. RedirectResult -> HelperMethod: Redirect() -> To redirect user to a URL.
            // 1. RedirectToRouteResult -> HelperMethod: RedirectToAction() -> To redirect to an action instead of a result.
            // 1. JSONResult -> HelperMethod: Json() -> To return a serialized json object.
            // 1. FileResult -> HelperMethod: File() -> To return a file.
            // 1. HTTPNotFoundResult -> HelperMethod: HTTPNotFound() -> To return a not found or a 404 error.
            // 1. EmptyResult -> HelperMethod:  -> When an action does not need to return any values -> void.

            // All the helper methods are in the base controller class.

        }

        public ActionResult Edit(int id)
        {
            return Content( "Id: " + id);
        }

        // To make a parameter optional, we have to make it nullable
        public ActionResult Index (int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue) { pageIndex = 1; }
            if(string.IsNullOrWhiteSpace(sortBy)) { sortBy = "Name"; }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}