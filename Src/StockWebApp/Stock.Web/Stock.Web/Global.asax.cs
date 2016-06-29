using Stock.Web.CustomExceptions;
using Stock.Web.DependencyManagement;
using Stock.Web.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace Stock.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            SetupDependencyManagement();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public override void Init()
        {
            PostAuthenticateRequest += App_PostAuthenticateRequest;
            base.Init();
        }

        private void SetupDependencyManagement()
        {
            var ninjectControllerFactory = new NinjectControllerFactory();
            ControllerBuilder.Current.SetControllerFactory(ninjectControllerFactory);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(ninjectControllerFactory.GetKernel()));
        }

        protected void Application_Error()
        {
            var exception = Server.GetLastError();
            var urlHelper = new UrlHelper(HttpContext.Current.Request.RequestContext);

            if (exception is UrlNotFoundException)
            {
                
                Response.Redirect(urlHelper.RouteUrl("Error404"), true);
            }
            else if (exception is SqlException)
            {
                Response.Redirect(urlHelper.RouteUrl("Error500"), true);
            }
        }



        void App_PostAuthenticateRequest(object sender, EventArgs e)
        {
            var authCookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
            if (authCookie != null)
            {
                var encTicket = authCookie.Value;
                if (!String.IsNullOrEmpty(encTicket))
                {
                    var ticket = FormsAuthentication.Decrypt(encTicket);
                    var id = new UserIdentity(ticket);
                    string[] userRoles = { "admin" };
                    var prin = new GenericPrincipal(id, userRoles);
                    HttpContext.Current.User = prin;
                }
            }
        }
    }
}