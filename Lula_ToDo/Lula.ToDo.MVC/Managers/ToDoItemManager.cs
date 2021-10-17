using System.Collections.Generic;
using Lula.ToDo.API.Models;

namespace Lula.ToDo.MVC.Managers
{
    public class ToDoItemManager
    {
        private Factory oFactory = new Factory();

        internal string AddToDoItem(string description, bool complete, bool active)
        {
            string html = "";

            ToDoItem item = oFactory.ToDoItemAPI.AddToDoItem(description);

            if (item.Success)
                AppendHtmlLine(item, ref html);

            return html;
        }

        internal string DeleteToDoItem(int id)
        {
            ToDoItem item = oFactory.ToDoItemAPI.DeleteToDoItem(id);

            if (item.Success)
                return "success"; // I would use these validation messages to communicate with the user when necessary.
            else
                return item.Message;
        }

        internal string UpdateToDoItem(int id, bool completeStatus, string description, bool active)
        {
            ToDoItem item = new ToDoItem() { ToDoItemID = id, Complete = completeStatus, Description = description, Active = active };
            
            item = oFactory.ToDoItemAPI.UpdateToDoItem(item);

            if (item.Success)
                return "success";
            else
                return item.Message;
        }

        internal string GetAll()
        {
            string html = "";
            List<ToDoItem> items = oFactory.ToDoItemAPI.GetAll();

            foreach (ToDoItem item in items)
                AppendHtmlLine(item, ref html);

            return html;
        }

        private void AppendHtmlLine(ToDoItem item, ref string html)
        {
            html += $"<div class=\"todo_item\" data-id=\"{item.ToDoItemID}\"><div><label class=\"checkbox_cont\"><input {(item.Complete ? "checked" : "")} type=\"checkbox\"/><span class=\"checkmark\"></span></label></div><p>{ item.Description }</p><div class=\"cross_icn\"><img src=\"./Content/images/icon-cross.svg\"></div></div>";
        }
    }
}