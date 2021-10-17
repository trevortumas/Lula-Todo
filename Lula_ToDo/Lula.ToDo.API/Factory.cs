namespace Lula.ToDo.API
{
    internal class Factory
    {
        private Managers.ToDoItemManager _ToDoItemManager;
        internal Managers.ToDoItemManager ToDoItemManager
        {
            get => _ToDoItemManager = _ToDoItemManager ?? new Managers.ToDoItemManager();
        }
    }
}