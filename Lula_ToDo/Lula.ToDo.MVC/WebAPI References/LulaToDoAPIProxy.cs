using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using Lula.ToDo.MVC.Helpers;

namespace Lula.ToDo.MVC.WebAPI_References
{
    internal class LulaToDoAPIProxy
    {
        // All of these hit ToDoController in Lula.ToDo.API
        internal API.Models.ToDoItem AddToDoItem(string description)
        {
            WebClient client = PrepareWebClient();
            API.Models.ToDoItem saveItem = new API.Models.ToDoItem() { Description = description };

            string inputJson = (new JavaScriptSerializer()).Serialize(saveItem);
            string json = client.UploadString(SettingsHelper.ApiBase + "/Add", inputJson);
            API.Models.ToDoItem item = (new JavaScriptSerializer()).Deserialize<API.Models.ToDoItem>(json);

            return item;
        }

        internal API.Models.ToDoItem DeleteToDoItem(int id)
        {
            WebClient client = PrepareWebClient();
            API.Models.ToDoItem deleteItem = new API.Models.ToDoItem() { ToDoItemID = id };

            string inputJson = (new JavaScriptSerializer()).Serialize(deleteItem);
            string json = client.UploadString(SettingsHelper.ApiBase + "/Delete", inputJson);
            API.Models.ToDoItem item = (new JavaScriptSerializer()).Deserialize<API.Models.ToDoItem>(json);

            return item;
        }

        internal API.Models.ToDoItem UpdateToDoItem(API.Models.ToDoItem updateItem)
        {
            WebClient client = PrepareWebClient();
            string inputJson = (new JavaScriptSerializer()).Serialize(updateItem);
            string json = client.UploadString(SettingsHelper.ApiBase + "/Update", inputJson);
            API.Models.ToDoItem item = (new JavaScriptSerializer()).Deserialize<API.Models.ToDoItem>(json);

            return item;
        }

        internal List<API.Models.ToDoItem> GetAll()
        {
            WebClient client = PrepareWebClient();
            string json = client.DownloadString(SettingsHelper.ApiBase + "/GetAll");
            List<API.Models.ToDoItem> items = (new JavaScriptSerializer()).Deserialize<List<API.Models.ToDoItem>>(json);

            return items;
        }

        private WebClient PrepareWebClient()
        {
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;

            return client;
        }
    }
}