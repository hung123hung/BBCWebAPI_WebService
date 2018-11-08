using BBCWebAPI.Data;
using BBCWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BBCWebAPI.Controllers;

namespace BBCWebAPI.ViewComponents
{
    [ViewComponent(Name ="DetailLesson")]
    public class DetailLessonViewComponent:ViewComponent
    {
        private readonly DataContext _dataContext;
        public DetailLessonViewComponent(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        public IViewComponentResult Invoke(string topicID)
        {
            List<Lesson> listLessons = (from lesson in _dataContext.Lessons
                               where lesson.IDTP == topicID
                               select lesson).ToList();
            ViewBag.listLessons = listLessons;           
            return View("Detail");
        }
    }
}
