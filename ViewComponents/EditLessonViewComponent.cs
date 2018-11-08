using BBCWebAPI.Data;
using BBCWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBCWebAPI.ViewComponents
{
    [ViewComponent(Name ="EditLesson")]
    public class EditLessonViewComponent:ViewComponent
    {
        private readonly DataContext _dataContext;
        public EditLessonViewComponent(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        public IViewComponentResult Invoke(string lessonID)
        {
            Lesson lessonItem = (from lesson in _dataContext.Lessons
                              where lesson.ID == lessonID
                              select lesson).SingleOrDefault();
            ViewBag.lessonItem = lessonItem;
            return View("Edit");
        }
    }
}
