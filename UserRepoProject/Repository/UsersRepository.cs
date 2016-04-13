using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UserRepoProject.Models;

namespace UserRepoProject.Repository
{
    public class UsersRepository
    {


        private static UsersRepository usersRepositoryInstance = new UsersRepository();

        private AppDbContext appDbContext = new AppDbContext();

        private UsersRepository() { }

        public void AddNewUser(UserDetails newUser)
        {

            appDbContext.Users.Add(newUser);
            appDbContext.SaveChanges();

        }

        public List<UserDetails> getAllUsersList()
        {
           return appDbContext.Users.ToList();
        }

        public static UsersRepository GetInstance()
        {
            
                return usersRepositoryInstance;
            
        }

    }


        
}