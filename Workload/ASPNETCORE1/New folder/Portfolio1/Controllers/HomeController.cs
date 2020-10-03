using Microsoft.AspNetCore.Mvc;
namespace Portfolio1
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public string Index()
        {
            return "Hello from Index";
        }

        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my projects";
        }

        [HttpGet("contact")]
        public string Contacts()
        {
            return "This is my Contact!";
        }
    }
}