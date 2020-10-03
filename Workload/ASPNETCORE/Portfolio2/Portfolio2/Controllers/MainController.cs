using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Portfolio2
{
    public class MainController : Controller
    {
        [HttpGet("")]
        public IActionResult Main()
        {
            return View("Index");
        }

        [HttpGet("projects")]
        public IActionResult Projects()
        {
            List<object> projectsList = new List<object>();
            projectsList.Add(new Project("spaceX", "just a rocket i built in my back yard", "spacex.jpg"));
            projectsList.Add(new Project("tesla", "just a car i built in my back yard", "tesla.jpg"));
            projectsList.Add(new Project("coffee", "just a cup of joe i made in my back yard", "coffee.jpg"));

            ViewBag.projectsList = projectsList;
            return View("projects");
        }

        [HttpGet("contacts")]
        public IActionResult Contacts()
        {
            return View("contacts");
        }
    }
}