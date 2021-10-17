using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lula.ToDo.MVC
{
    public class Factory
    {
        private Managers.ToDoItemManager _ToDoItemManager;
        internal Managers.ToDoItemManager ToDoItemManager
        {
            get => _ToDoItemManager = _ToDoItemManager ?? new Managers.ToDoItemManager();
        }

        private API.Controllers.ToDoController _ToDoItemAPI;
        internal API.Controllers.ToDoController ToDoItemAPI
        {
            get => _ToDoItemAPI = _ToDoItemAPI ?? new API.Controllers.ToDoController();
        }
    }
}