using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lula.ToDo.API.Models
{
    public class ModelBase
    {
        public string Message { get; set; }
        public string Success { get; set; }

        public ModelBase(string message, string success)
        {
            Message = message;
            Success = success;
        }

        public ModelBase()
        {
        }
    }
}