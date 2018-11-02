using BBCWebAPI.Data;
using BBCWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBCWebAPI.Controllers.UI
{
    public class HomeController:Controller
    {
        private User user;
        private DataContext dataContext;
        public HomeController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [Route("/HomePage")]
        public IActionResult HomePage()
        {
            try
            {
                List<Topic> listTopics = new List<Topic>();
                listTopics = dataContext.Topics.ToList();
                ViewBag.listTopics = listTopics;
                return View("Views/HomePage.cshtml");
            }
            catch(Exception ex)
            {

            }
            return View("Views/HomePage.cshtml");
        }
    }
}
