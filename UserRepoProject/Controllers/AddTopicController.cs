using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserRepoProject.Models;
using UserRepoProject.Repository;

namespace UserRepoProject.Controllers
{
    public class AddTopicController : Controller
    {

        private TopicsRepository topicsRepository = TopicsRepository.GetInstance();

        public ActionResult AddNew()
        {
            return View("AddTopicPage");
        }

        [HttpPost]
        public ActionResult AddNew(Topic topic)
        {

            topicsRepository.addTopic(topic);

            return View("AddTopicPage");
        }
    }
}