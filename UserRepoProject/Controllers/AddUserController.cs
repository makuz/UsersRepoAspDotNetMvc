using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserRepoProject.Models;
using UserRepoProject.Repository;

namespace UserRepoProject.Controllers
{
    public class AddUserController : Controller
    {


        UsersRepository usersRepository = UsersRepository.GetInstance();

        // GET: AddUser
        public ActionResult AddUserFormPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUserFormPage(UserDetails newUser)
        {

            usersRepository.AddNewUser(newUser);

            return RedirectToAction("UsersTablePage", "UsersTable", new { area = "" });
        }
    }
}