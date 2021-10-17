using System;
using System.Collections.Generic;
using System.Linq;

namespace Lula.ToDo.API.Managers
{
    internal class ToDoItemManager
    {
        private Factory oFactory = new Factory();

        internal Models.ToDoItem Add(Models.ToDoItem newItem)
        {
            // validate
            if (string.IsNullOrEmpty(newItem.Description))
            {
                newItem.Success = false;
                newItem.Message = "Description may not be blank.";
            }

            try
            {
                // if validation succeeds, below is a DB call to save the object to a table. 
                using (var context = new Data.dbToDoEntities())
                {
                    // side note: using entity framework to manage database calls would normally not be how I'd go about this. 
                    // I did it for simplicity here.
                    // normally I would have a dedicated DB server to connect to
                    context.ToDoItems_Add(newItem.Description, true, false);
                }

                newItem.Success = true;
            }
            catch (Exception ex)
            {
                newItem.Success = false;
                newItem.Message = $"To do item save failed: {ex.Message} | {ex.InnerException}";
            }

            return newItem;
        }

        internal Models.ToDoItem Delete(Models.ToDoItem item)
        {
            try
            {
                using (var context = new Data.dbToDoEntities())
                {
                    context.ToDoItems_Delete(item.ToDoItemID);
                }

                item.Success = true;
            }
            catch (Exception ex)
            {
                item.Success = false;
                item.Message = $"Delete operation failed: {ex.Message} | {ex.InnerException}";
            }

            return item;
        }

        internal Models.ToDoItem Update(Models.ToDoItem newItem)
        {
            try
            {
                // if validation succeeds, below is a DB call to save the object to a table. 
                using (var context = new Data.dbToDoEntities())
                {
                    context.ToDoItems_Update(newItem.ToDoItemID, newItem.Description, newItem.Active, newItem.Complete);
                }

                newItem.Success = true;
            }
            catch (Exception ex)
            {
                newItem.Success = false;
                newItem.Message = $"To do item update failed: {ex.Message} | {ex.InnerException}";
            }

            return newItem;
        }

        internal List<Models.ToDoItem> GetAll()
        {
            List<Models.ToDoItem> toDos = new List<Models.ToDoItem>();

            using (var context = new Data.dbToDoEntities())
            {
                toDos = context.ToDoItems_GetAll().Select(i => new Models.ToDoItem()
                {
                    ToDoItemID = i.ItemID,
                    Description = i.Description,
                    Active = (bool)i.Active,
                    Complete = (bool)i.Complete
                }).ToList();
            }

            return toDos;
        }
    }
}