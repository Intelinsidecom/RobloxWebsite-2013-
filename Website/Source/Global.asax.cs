using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.UI.WebControls;
using System.Net;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Platform.Membership;
using Roblox.Platform.Roles;
using Roblox.Platform.Email;
using Roblox.Platform.Authentication;
using Roblox.Platform.Security;
using Roblox.Website.Factories;
using Roblox.Platform.Authentication.AccountSecurity;

namespace Roblox.Website
{
    public class Global : HttpApplication
    {
        private static RobloxWebsiteLogger _logger;
        private static RolesDomainFactories _rolesDomainFactories;
        private static EmailDomainFactories _emailDomainFactories;
        private static MembershipDomainFactories _membershipDomainFactories;
        private static SecurityDomainFactories _securityDomainFactories;
        private static CredentialValidator _credentialValidator;

        public static RobloxWebsiteLogger Logger
        {
            get
            {
                if (_logger == null)
                {
                    _logger = new RobloxWebsiteLogger();
                }
                return _logger;
            }
        }

        public static RolesDomainFactories RolesDomainFactories
        {
            get
            {
                if (_rolesDomainFactories == null)
                {
                    _rolesDomainFactories = new RolesDomainFactories(
                        logger: Logger
                    );
                }
                return _rolesDomainFactories;
            }
            private set { _rolesDomainFactories = value; }
        }

        public static EmailDomainFactories EmailDomainFactories
        {
            get
            {
                if (_emailDomainFactories == null)
                {
                    _emailDomainFactories = new EmailDomainFactories(
                        logger: Logger
                    );
                }
                return _emailDomainFactories;
            }
            private set { _emailDomainFactories = value; }
        }

        public static MembershipDomainFactories MembershipDomainFactories
        {
            get
            {
                if (_membershipDomainFactories == null)
                {
                    _membershipDomainFactories = new MembershipDomainFactories(
                        logger: Logger,
                        rolesDomainFactories: RolesDomainFactories,
                        emailDomainFactories: EmailDomainFactories
                    );
                }
                return _membershipDomainFactories;
            }
            private set { _membershipDomainFactories = value; }
        }

        public static SecurityDomainFactories SecurityDomainFactories
        {
            get
            {
                if (_securityDomainFactories == null)
                {
                    _securityDomainFactories = new SecurityDomainFactories(
                        logger: Logger
                    );
                }
                return _securityDomainFactories;
            }
            private set { _securityDomainFactories = value; }
        }

        private static AuthenticationDomainFactories _authenticationDomainFactories;

        public static AuthenticationDomainFactories AuthenticationDomainFactories
        {
            get
            {
                if (_authenticationDomainFactories == null)
                {
                    _authenticationDomainFactories = new AuthenticationDomainFactories(
                        logger: Logger,
                        securityDomainFactories: SecurityDomainFactories,
                        membershipDomainFactories: MembershipDomainFactories,
                        emailDomainFactories: EmailDomainFactories
                    );
                }
                return _authenticationDomainFactories;
            }
        }

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
            var user = MembershipDomainFactories.UserFactory.GetCurrentUser();
            if (user != null && user.AccountStatus != Platform.Membership.AccountStatus.Ok)
            {
                var isPrivileged = MembershipDomainFactories.RoleSetValidator.IsPrivilegedUser(user);
                if (!isPrivileged)
                {
                    var notApprovedPage = "/Membership/NotApproved.aspx";

                    if (!Request.Url.AbsolutePath.ToLower().EndsWith(notApprovedPage.ToLower()))
                    {
                        Response.Redirect("~" + notApprovedPage, true);
                    }
                }
            }
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
            // Domain factories are now initialized lazily in their property getters
            // This method is kept for compatibility but does nothing
        }

        private void DoOtherConfig()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebControl.DisabledCssClass = "disabled";
        }
    }
}
