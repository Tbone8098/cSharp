using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace TimeDisplay
{
    public class MainController : Controller
    {
        [HttpGet("")]
        public IActionResult Main()
        {
            DateTime CurrentTime = DateTime.Now;
            string DateNow = CurrentTime.ToString("MMM dd, yyyy");
            string TimeNow = CurrentTime.ToString("h:mm tt");

            List<object> DT = new List<object>();
            DT.Add(DateNow);
            DT.Add(TimeNow);

            ViewBag.DT = DT;

            return View("Index");
        }
    }
}