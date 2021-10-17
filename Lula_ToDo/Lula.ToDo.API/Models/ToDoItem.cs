namespace Lula.ToDo.API.Models
{
    public class ToDoItem : ModelBase
    {
        public int ToDoItemID { get; set; }
        public string Description { get; set; }
        public bool Complete { get; set; }
        public bool Active { get; set; }

        public ToDoItem(int toDoItemID, string description, bool complete, bool active)
        {
            ToDoItemID = toDoItemID;
            Description = description;
            Complete = complete;
            Active = active;
        }

        public ToDoItem()
        {
        }
    }
}