using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey
{
    public class MainController : Controller
    {
        [HttpGet("")]
        public IActionResult Main()
        {
            return View("Index");
        }

        [HttpPost("getForm")]
        public IActionResult getForm(string name, string dojoLoc, string favLang, string comments)
        {
            string Name = name;
            string DojoLoc = dojoLoc;
            string FavLang = favLang;
            string Comments = comments;

            return RedirectToAction("OtherMethod", new { Name = name, DojoLoc = dojoLoc, FavLang = favLang, Comments = comments });
        }

        [HttpGet("OtherMethod/{Name}/{DojoLoc}/{FavLang}/{Comments}")]
        public ViewResult OtherMethod(string name, string dojoLoc, string favLang, string comments)
        {
            ViewBag.name = name;
            ViewBag.dojoLoc = dojoLoc;
            ViewBag.favLang = favLang;
            ViewBag.comments = comments;

            return View("Results");
        }
    }
}