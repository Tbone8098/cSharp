using Microsoft.AspNetCore.Mvc;

namespace RazorFun
{
    public class MainController : Controller
    {
        [HttpGet("")]
        public ViewResult MainPage()
        {
            return View("Index");
        }
    }
}