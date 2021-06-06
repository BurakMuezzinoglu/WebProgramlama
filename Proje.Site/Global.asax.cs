using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;

namespace Proje.Site
{
    public class Global : System.Web.HttpApplication
    {       
        void Yonlendir(RouteCollection route)
        {
            route.MapPageRoute("Deneme","Gorsel/{GorselId}/{KullaniciId}","~/Test3.aspx");

        }
        protected void Application_Start(object sender, EventArgs e)
        {
            Yonlendir(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}