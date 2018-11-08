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
        private DataContext dataContext;
        public HomeController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        [Route("/HomePage")]
        public IActionResult HomePage(string topicID,string topicName)
        {
            try
            {
                List<Topic> listTopics = new List<Topic>();
                listTopics = dataContext.Topics.ToList();
                //send list Topic to View HomePage
                ViewBag.listTopics = listTopics;   
                //send id topic to View HomePage
                ViewBag.topicID = topicID;
                //send name topic to View HomePage
                ViewBag.NameTopic = topicName;
                ShowDetailLesson(topicID);
                return View("Views/Pages/HomePage.cshtml");
            }
            catch(Exception ex)
            {

            }
            return null;
        }
        [Route("/HomePage/EditLessonPage")]
        public IActionResult EditLessonPage(string topicID, string topicName, string lessonID)
        {
            try
            {
                List<Topic> listTopics = new List<Topic>();
                listTopics = dataContext.Topics.ToList();
                //send list Topic to View HomePage
                ViewBag.listTopics = listTopics;
                //send id topic to View HomePage               
                ViewBag.topicID = topicID;
                //send name topic to View HomePage
                ViewBag.NameTopic = topicName;
                //send lessonID to another Action Controller
                TempData["lessonID"] = lessonID;
                ShowDetailLesson(topicID);
                ShowEditLesson(lessonID);
                return View("Views/Pages/EditLessonPage.cshtml");
            }
            catch (Exception ex)
            {

            }
            return View("Views/Pages/HomePage.cshtml");
        }
        [Route("/HomePage/EditLessonPage/UpdateLesson")]
        public IActionResult UpdateLesson(string nameLesson, string year, string audioURLOnline, string audioURLDowload,
            string imageURL, string transcript, string actor, string summary, string vocabulary, string createdDate)
        {
            try
            {
                string lessonID = (string)TempData["lessonID"];
                var update = dataContext.Lessons.Where(lesson => lesson.ID == lessonID).FirstOrDefault();
                if(update!=null)
                {
                    update.Name = nameLesson;
                    update.Year = Int32.Parse(year);
                    update.FileURLOnline = audioURLOnline;
                    update.FileURLDowload = audioURLDowload;
                    update.ImageURL = imageURL;
                    update.Transcript = transcript;
                    update.Actor = actor;
                    update.Sumary = summary;
                    update.Vocabulary = vocabulary;
                    update.CreatedDate = createdDate;
                    update.UpdatedDate = (DateTime.Now).ToString();
                }
                
                dataContext.SaveChangesAsync();
                return RedirectToAction("HomePage");
            }
            catch(Exception ex)
            { }
            return RedirectToAction("EditLessonPage");
        }
        public void ShowDetailLesson(string topicID)
        {
            List<Lesson> listLessons = new List<Lesson>();
            if (topicID!=null)
            {
                 listLessons = (from lesson in dataContext.Lessons
                                            where lesson.IDTP == topicID
                                            select lesson).ToList();                
            }
            else
            {
                listLessons = (from lesson in dataContext.Lessons
                               where lesson.IDTP == "6M"
                               select lesson).ToList();
            }
            ViewBag.listLessons = listLessons;
        }
        public void ShowEditLesson(string lessonID)
        {
            Lesson lessonItem = (from lesson in dataContext.Lessons
                                 where lesson.ID == lessonID
                                 select lesson).SingleOrDefault();
            ViewBag.lessonItem = lessonItem;
        }
    }
}
