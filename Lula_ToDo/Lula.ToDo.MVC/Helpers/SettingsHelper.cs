using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lula.ToDo.MVC.Helpers
{
    public class SettingsHelper
    {
        internal static string ApiBase
        {
            get => "http://localhost/Lula.ToDo.API/api/ToDo";
        }
    }
}