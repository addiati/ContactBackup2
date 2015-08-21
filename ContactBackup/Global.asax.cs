using ContactBackup.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ContactBackup
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            Database.SetInitializer(new DbInitializer());

            // Now initialize it
            using (var context = new ContactBackupContext())
            {
                context.Database.Initialize(false);
            }

        }
    }
}
