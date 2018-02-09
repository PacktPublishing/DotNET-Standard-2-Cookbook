using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chapter2.Linq.QueriesLib;

namespace Chapter2.Linq.QueriesMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var telephoneBook = new TelephoneBook();
          
            ViewBag.Contacts = telephoneBook.GetContacts();

            return View();
        }

        public ActionResult Search(string ln)
        {

            var telephoneBook = new TelephoneBook();

            if (string.IsNullOrEmpty(ln))
            {
                ViewBag.Contacts = telephoneBook.GetContacts();

            }
            else
            {
                ViewBag.Contacts = telephoneBook.GetContactsByLastName(ln);
            }

            return View();
        }

        public ActionResult SortedContacts(bool asc = true)
        {
            var telephoneBook = new TelephoneBook();

            ViewBag.Contacts = telephoneBook.GetSortedContacts(asc);

            return View();
        }
    }
}