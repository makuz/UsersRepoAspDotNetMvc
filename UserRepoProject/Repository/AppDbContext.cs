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

        public DbSet<UserDetails> Users { get; set; }

    }
}