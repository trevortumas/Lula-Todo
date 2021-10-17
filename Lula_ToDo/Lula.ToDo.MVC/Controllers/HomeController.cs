using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lula.ToDo.MVC.Controllers
{
    public class HomeController : Controller
    {
        // I was not able to complete the assignment. 
        // In summary, I got hung up on getting the API to take requests.
        // Most of the main structure/skeleton got built out, but doesn't work right.
        // I could have gotten there with more time, but unfortunately let myself get 
        // hung up on the API stuff. 
        private Factory oFactory = new Factory();
        public ActionResult Index()
        {
            return View();
        }

        public string AddToDoItem(string description, bool complete, bool active)
        {
            return oFactory.ToDoItemManager.AddToDoItem(description, complete, active);
        }
    }
}