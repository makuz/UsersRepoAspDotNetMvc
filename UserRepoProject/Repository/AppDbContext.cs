using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UserRepoProject.Models;

namespace UserRepoProject.Repository
{
    public class AppDbContext : DbContext
    {

        private static AppDbContext appDbContext = new AppDbContext();

        public static AppDbContext GetInstance()
        {
            return appDbContext;
        }

        public DbSet<UserDetails> Users { get; set; }

        public DbSet<Topic> topics { get; set; }

    }
}