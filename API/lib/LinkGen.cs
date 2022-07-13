using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Routing;

namespace API.lib
{
    public static class LinkGen
    {
        public static List<API.lib.Link> _Links { get; set; }
        public static void GenerateLinks(this ControllerBase controllerBase)
        {
            var httpsMethods = from m in controllerBase.GetType().GetMethods()
                       where m.GetCustomAttributes().Any(a => a is HttpMethodAttribute)
                       select m;

            foreach (var methodInfo in httpsMethods)
            {

            }

            //foreach(var att in attributes)
            //{
            //}

        }
    }
}
