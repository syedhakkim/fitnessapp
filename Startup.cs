using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(FitnessTrackerApp.Startup))]

namespace FitnessTrackerApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // You can configure auth, middleware, etc. here
        }
    }
}
