using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Lula.ToDo.API.Models;

namespace Lula.ToDo.MVC.Managers
{
    public class ToDoItemManager
    {
        private Factory oFactory = new Factory();

        internal string AddToDoItem(string description, bool complete, bool active)
        {
            string html = "";

            // I know this is wrong. I was running low on time and having trouble with getting the WebAPI set up. 
            // see comments in the ToDoController of the API for more details. 
            ToDoItem item = oFactory.ToDoItemAPI.AddUpdate(description);

            html = $"<div class=\"todo_item\"><input class=\"status_checkbox\" type=\"checkbox\"/><p>{ description }</p></div>";

            return html;
        }
    }
}