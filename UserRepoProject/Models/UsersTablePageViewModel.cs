using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserRepoProject.Repository;

namespace UserRepoProject.Models
{
    public class UsersTablePageViewModel
    {

       public UsersRepository usersRepository = UsersRepository.GetInstance();

        public string modelTitle { get { return "Users From Db"; } }

    }
}