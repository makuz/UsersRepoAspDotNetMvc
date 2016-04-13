using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserRepoProject.Models;
using UserRepoProject.Repository;

namespace UserRepoProject.Controllers
{
    public class UsersTableController : Controller
    {
        

        // GET: UsersTable
        public ActionResult UsersTablePage()
        {
            return View(new UsersTablePageViewModel());
        }
    }
}