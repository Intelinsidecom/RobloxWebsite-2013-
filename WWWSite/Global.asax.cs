using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.UI.WebControls;
using System.Net;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Platform.Membership;
using Roblox.Platform.Email;
using Roblox.Platform.Authentication;
using Roblox.Platform.Security;
using Roblox.Instrumentation;

namespace Roblox.Website
{
    public class Global : System.Web.HttpApplication
    {

        public static ILogger Logger { get; private set; }
        public static ICounterRegistry CounterRegistry { get; private set; }

        public static MembershipDomainFactories MembershipDomainFactories { get; private set; }
        public static EmailDomainFactories EmailDomainFactories { get; private set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            CreateLogger();
            ConfigureDomainFactories();
            DoOtherConfig();

            ConfigureCookieConstraint();
        }

        public void Application_Error(object sender, EventArgs e)
        {
            Exception exc = Server.GetLastError();
            if (exc != null)
            {
                // If this is an unhandled exception, skip to the actual exception and handle it
                if (exc.GetType() == typeof(HttpUnhandledException) && exc.InnerException != null)
                    exc = exc.InnerException;

                if (exc.GetType() == typeof(HttpException))
                {
                    if (Response.IsClientConnected)
                        Response.Redirect("~/RobloxDefaultErrorPage.aspx?code=" + ((HttpException)exc).GetHttpCode(), true);
                }
                else
                {
                    LogException(exc);
                }
            }
            else
            {
                // Something went very wrong
                if (Response.IsClientConnected)
                    Response.Redirect("~/RobloxDefaultErrorPage.aspx?code=500", true);
            }
        }

        public void Application_PostAuthenticateRequest(object sender, EventArgs e)
        {
           
        }

        public static string LogException(Exception e)
        {
            // TODO: Log using uber-advanced exception logging technology
            Logger.Error(e);
            return Guid.NewGuid().ToString();
        }

        private void ConfigureCookieConstraint()
        {

        }

        /// <summary>
        /// Sets up and configures the logger for the current application and its assemblies.
        /// </summary>
        private void CreateLogger()
        {

        }

        private void ConfigureDomainFactories()
        {
//            MembershipDomainFactories = new MembershipDomainFactories(
//                logger: Logger,
//                counterRegistry: CounterRegistry,
//                emailDomainFactories: EmailDomainFactories
//            );
        }

        private void DoOtherConfig()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebControl.DisabledCssClass = "disabled";
        }
    }
}
