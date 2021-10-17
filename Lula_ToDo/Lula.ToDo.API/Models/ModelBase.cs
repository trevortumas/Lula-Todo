namespace Lula.ToDo.API.Models
{
    public class ModelBase
    {
        public string Message { get; set; }
        public bool Success { get; set; }

        public ModelBase(string message, bool success)
        {
            Message = message;
            Success = success;
        }

        public ModelBase()
        {
        }
    }
}