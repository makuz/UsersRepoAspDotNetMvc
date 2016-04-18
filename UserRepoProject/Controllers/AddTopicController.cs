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

        private UsersRepository usersRepository = UsersRepository.GetInstance();

        public ActionResult AddNew()
        {

            AddTopicView atv = new AddTopicView();

            atv.topic = new Topic();
            atv.allUsers = usersRepository.getAllUsersList();

            return View("AddTopicPage", atv);
        }

        [HttpPost]
        public ActionResult AddNew(AddTopicView topicViewModel)
        {

            Topic newTopic = topicViewModel.topic;
            int TopicUserID = topicViewModel.selectedUserId;

            UserDetails topicUser = usersRepository.findOneByPk(TopicUserID);

            newTopic.Author = topicUser;
      
            topicsRepository.addTopic(newTopic);

            return View("AddTopicPage");
        }


        public ActionResult showAllTopics()
        {

            AllTopicsViewModel vm = new AllTopicsViewModel();
            vm.AllTopics = topicsRepository.findAll();

            return View("AllTopicsPage", vm);
        }
    }
}