using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserRepoProject.Models
{
    public class Topic
    {

        public long TopicId { get; set; }

        public UserDetails Author;

        public string Title { get; set; }

        public string Content { get; set; }

    }
}