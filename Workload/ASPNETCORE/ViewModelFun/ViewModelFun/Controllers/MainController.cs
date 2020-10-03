using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViewModelFun.Models;


namespace ViewModelFun
{
    public class MainController : Controller
    {
        [HttpGet("")]
        public IActionResult Main()
        {
            string message = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Accusantium quasi quam nostrum vel. Beatae iste, placeat dolor maxime nam asperiores ducimus facilis labore vel consequatur, tempora porro! Eum, aliquid quas! Lorem ipsum dolor sit amet consectetur adipisicing elit. Nobis deserunt pariatur assumenda ducimus tempore vitae, mollitia deleniti omnis voluptatibus earum architecto blanditiis nulla ratione, asperiores ad quaerat! Hic, reprehenderit temporibus? Lorem ipsum, dolor sit amet consectetur adipisicing elit. Cum aliquid facere est voluptatibus eaque tempora quos porro ducimus nulla minima totam, et quod cupiditate doloribus similique magnam ipsa commodi labore. Lorem ipsum dolor sit, amet consectetur adipisicing elit. Maxime perferendis ad veritatis libero incidunt animi! Error deleniti debitis velit sunt veritatis eveniet veniam cumque aperiam! Doloremque officia impedit quibusdam itaque?";

            return View("Index", message);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] myNumbers = new int[] { 1, 2, 4, 3, 6, 7 };
            return View("NumbersPage", myNumbers);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            List<User> myUsers = new List<User>();

            User Tyler = new User("Tyler", "Tdog@gmail.com");
            User Tom = new User("Tom", "tom@gmail.com");
            User Ken = new User("Ken", "Ken@gmail.com");
            User Peter = new User("Peter", "Peter@gmail.com");

            myUsers.Add(Tyler);
            myUsers.Add(Tom);
            myUsers.Add(Ken);
            myUsers.Add(Peter);

            return View("users", myUsers);
        }

        [HttpGet("user")]
        public IActionResult User()
        {
            User Kendal = new User("Kendal", "Kdog@gmail.com");
            return View("user", Kendal);
        }
    }
}