using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserRepoProject.Models;

namespace UserRepoProject.Repository
{
    public class TopicsRepository
    {

        private AppDbContext appDbContext = AppDbContext.GetInstance();

        private static TopicsRepository topicsRepository = new TopicsRepository();

        private TopicsRepository() { }


        public static TopicsRepository GetInstance()
        {
            return topicsRepository;
        }


        public void addTopic(Topic newTopic)
        {
            appDbContext.Topics.Add(newTopic);
            appDbContext.SaveChanges();
        }


        public List<Topic> findAll()
        {
            return appDbContext.Topics.ToList();
        }


    }
}