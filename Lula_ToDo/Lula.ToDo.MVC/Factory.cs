namespace Lula.ToDo.MVC
{
    public class Factory
    {
        private Managers.ToDoItemManager _ToDoItemManager;
        internal Managers.ToDoItemManager ToDoItemManager
        {
            get => _ToDoItemManager = _ToDoItemManager ?? new Managers.ToDoItemManager();
        }

        private WebAPI_References.LulaToDoAPIProxy _ToDoItemAPI;
        internal WebAPI_References.LulaToDoAPIProxy ToDoItemAPI
        {
            get => _ToDoItemAPI = _ToDoItemAPI ?? new WebAPI_References.LulaToDoAPIProxy();
        }
    }
}