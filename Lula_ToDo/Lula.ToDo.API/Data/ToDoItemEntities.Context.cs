//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lula.ToDo.API.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbToDoEntities : DbContext
    {
        public dbToDoEntities()
            : base("name=dbToDoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ToDoItem> ToDoItems { get; set; }
    
        public virtual int ToDoItems_Add(string description, Nullable<bool> active, Nullable<bool> complete)
        {
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(bool));
    
            var completeParameter = complete.HasValue ?
                new ObjectParameter("Complete", complete) :
                new ObjectParameter("Complete", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ToDoItems_Add", descriptionParameter, activeParameter, completeParameter);
        }
    
        public virtual int ToDoItems_Delete(Nullable<int> itemID)
        {
            var itemIDParameter = itemID.HasValue ?
                new ObjectParameter("ItemID", itemID) :
                new ObjectParameter("ItemID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ToDoItems_Delete", itemIDParameter);
        }
    
        public virtual ObjectResult<ToDoItems_GetAll_Result> ToDoItems_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ToDoItems_GetAll_Result>("ToDoItems_GetAll");
        }
    
        public virtual int ToDoItems_Update(Nullable<int> toDoID, string description, Nullable<bool> active, Nullable<bool> complete)
        {
            var toDoIDParameter = toDoID.HasValue ?
                new ObjectParameter("ToDoID", toDoID) :
                new ObjectParameter("ToDoID", typeof(int));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("Active", active) :
                new ObjectParameter("Active", typeof(bool));
    
            var completeParameter = complete.HasValue ?
                new ObjectParameter("Complete", complete) :
                new ObjectParameter("Complete", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ToDoItems_Update", toDoIDParameter, descriptionParameter, activeParameter, completeParameter);
        }
    }
}
