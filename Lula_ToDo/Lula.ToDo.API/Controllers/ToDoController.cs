using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace Lula.ToDo.API.Controllers
{
    [RoutePrefix("api/ToDo")]
    public class ToDoController
    {
        // This is how I would normally set up a basic controller for an API. 
        // I realized as I started doing this that I admittedly didn't know how to
        // set this up from scratch to be able to make web requests from my MVC project. 
        // At my job, there's a framework set up that takes care of all of this. I wasted
        // a lot of time trying to figure it out for this assignment.
        private Factory oFactory = new Factory();

        [HttpPost]
        [Route("AddUpdate")]
        public Models.ToDoItem AddUpdate(string description)
        {
            return oFactory.ToDoItemManager.AddUpdate(description);
        }

        [HttpPost]
        [Route("Delete")]
        public string Delete(int id)
        {
            return "";
        }

        [HttpGet]
        [Route("GetList")]
        public string GetList()
        {
            return "";
        }
    }
}