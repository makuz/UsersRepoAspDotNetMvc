using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserRepoProject.Models
{
    public class AddTopicView
    {

        public Topic topic  {get; set; }

        public List<UserDetails> allUsers { get; set; }

        public int selectedUserId { get;  set;}

    }
}