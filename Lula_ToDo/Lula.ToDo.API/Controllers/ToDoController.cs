using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace Lula.ToDo.API.Controllers
{
    [RoutePrefix("api/ToDo")]
    public class ToDoController
    {
        [HttpPost]
        [Route("AddUpdate")]
        public string AddUpdate()
        {
            return "";
        }

        [HttpPost]
        [Route("Delete")]
        public string Delete(int id)
        {
            return "";
        }

        [HttpGet]
        [Route("GetList")]
        public string GetList()
        {
            return "";
        }
    }
}