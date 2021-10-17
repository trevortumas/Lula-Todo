using System;
using System.Web.Mvc;

namespace Lula.ToDo.MVC.Controllers
{
    public class HomeController : Controller
    {
        private Factory oFactory = new Factory();
        public ActionResult Index()
        {
            return View();
        }

        public string AddToDoItem(string description, bool complete, bool active)
        {
            return oFactory.ToDoItemManager.AddToDoItem(description, complete, active);
        }

        public string DeleteToDoItem(int id)
        {
            return oFactory.ToDoItemManager.DeleteToDoItem(id);
        }

        public string GetAll()
        {
            return oFactory.ToDoItemManager.GetAll();
        }

        public string UpdateToDoItem(string id, bool completeStatus, string description, bool active)
        {
            return oFactory.ToDoItemManager.UpdateToDoItem(Convert.ToInt32(id), completeStatus, description, active);
        }
    }
}