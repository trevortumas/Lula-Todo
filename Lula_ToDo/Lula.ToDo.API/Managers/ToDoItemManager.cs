using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lula.ToDo.API.Managers
{
    internal class ToDoItemManager
    {
        private Factory oFactory = new Factory();

        internal Models.ToDoItem AddUpdate(string description)
        {
            Models.ToDoItem newItem = new Models.ToDoItem() { Description = description, Active = true, Complete = false };

            try
            {
                // this is where I would do validation of the input. I would use the ModelBase to communicate success/failure w/ a message.


                // if validation succeeds, below is a DB call to save the object to a table. 
                oFactory.dbToDoItemData.AddUpdateToDoItem(ref newItem);
            }
            catch (Exception ex)
            {
                //log
            }

            return new Models.ToDoItem();
        }

        internal Models.ToDoItem Delete(Models.ToDoItem item)
        {
            return new Models.ToDoItem();
        }
    }
}