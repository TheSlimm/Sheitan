using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restup.Webserver.Rest;

namespace BackgroundApplication3
{
    class ModuleController
    {
        public RestRouteHandler RegisterModule()
        {
            var restRouteHandler = new RestRouteHandler();

            restRouteHandler.RegisterController<SheitanController>();

            return restRouteHandler;
        }
    }
}
