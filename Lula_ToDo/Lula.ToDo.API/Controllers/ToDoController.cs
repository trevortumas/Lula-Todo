using System.Collections.Generic;
using System.Web.Http;

namespace Lula.ToDo.API.Controllers
{
    [RoutePrefix("api/ToDo")]
    public class ToDoController : ApiController
    {
        private Factory oFactory = new Factory();

        [HttpPost]
        [Route("Add")]
        public Models.ToDoItem Add(Models.ToDoItem item)
        {
            return oFactory.ToDoItemManager.Add(item);
        }

        [HttpPost]
        [Route("Delete")]
        public Models.ToDoItem Delete(Models.ToDoItem item)
        {
            return oFactory.ToDoItemManager.Delete(item);
        }

        [HttpPost]
        [Route("Update")]
        public Models.ToDoItem Update(Models.ToDoItem item)
        {
            return oFactory.ToDoItemManager.Update(item);
        }

        [HttpGet]
        [Route("GetAll")]
        public List<Models.ToDoItem> GetAllToDoItems()
        {
            return oFactory.ToDoItemManager.GetAll();
        }
    }
}