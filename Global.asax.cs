using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SignalR.WebConsole
{
    // a digital comment
    // a remote comment
<<<<<<< HEAD
    // another REMOTE comment
=======
    // a LOCAL comment
>>>>>>> local comments
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
