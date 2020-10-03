using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithModel.Models;

namespace DojoSurveyWithModel
{
    public class MainController : Controller
    {
        [HttpGet("")]
        public IActionResult Main()
        {
            return View("Index");
        }

        [HttpPost("register")]
        public IActionResult FormPost(Survey formInfo)
        {
            string name = formInfo.Name;
            string dojoLoc = formInfo.DojoLoc;
            string favLang = formInfo.FavLang;
            string comments = formInfo.Comments;
            return RedirectToAction("DisplayResults", new { Name = name, DojoLoc = dojoLoc, FavLang = favLang, Comments = comments });
        }

        [HttpGet("DisplayResults/{Name}/{DojoLoc}/{FavLang}/{Comments}")]
        public IActionResult DisplayResults(string Name, string DojoLoc, string FavLang, string Comments)
        {
            System.Console.WriteLine(Name);
            System.Console.WriteLine(DojoLoc);
            System.Console.WriteLine(FavLang);
            System.Console.WriteLine(Comments);
            return View("Results");
        }
    }
}