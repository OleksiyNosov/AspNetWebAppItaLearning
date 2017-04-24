using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp
{
    public class MyActionFilter : ActionFilterAttribute
    {
        void OnAcyionExecuted(ActionExecutedContext filteContext)
        {
            var controllerName = filteContext.Controller
                                             .ControllerContext
                                             .RequestContext
                                             .RouteData
                                             .Values
                                             .First()
                                             .Value;
            List<string> headers = null;
        }
    }
}