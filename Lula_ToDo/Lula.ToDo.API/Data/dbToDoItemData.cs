using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lula.ToDo.API.Data
{
    public class dbToDoItemData
    {
        internal void AddUpdateToDoItem(ref Models.ToDoItem item)
        {
            // parse JSON file, read it to see if item exists
            // if item exists, overwrite with new values. If not, write new item as-is and increment ID to use as PK
            // normally if this was a true production app, I would create/use a SQL database to manage this. 
            // In transparency, I wasn't sure how the DB connection would work in Visual Studio and pushing it to Git, so I didn't dwell on it and opted to read/write a json file to save time.
        }
    }
}