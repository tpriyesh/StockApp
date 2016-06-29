#region Disclaimer/License Info

/* *********************************************** */

// sBlog.Net

// sBlog.Net is a minimalistic blog engine software.

// Homepage: http://sblogproject.net
// Github: http://github.com/karthik25/sBlog.Net

// This project is licensed under the BSD license.  
// See the License.txt file for more information.

/* *********************************************** */

#endregion
using System;
using System.Data.SqlClient;
using System.Web.Mvc;
using Stock.Web.Infrastructure;
using System.Web.Routing;
using Stock.Web.CustomExceptions;

namespace Stock.Web.Filters
{
    public class StockErrorAttribute : HandleErrorAttribute
    {
        /// <summary>
        /// Called when an exception occurs.
        /// 
        /// Depending on the type of exception, user is redirected to a corresponding page
        /// 
        ///     * UrlNotFoundException -> 404 page
        ///     * Any other exception -> a generic error page
        /// </summary>
        /// <param name="filterContext">The action-filter context.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="filterContext"/> parameter is null.</exception>
        public override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                filterContext.Result = new JsonResult
                {
                    Data = new
                    {
                        Message = "An error occured"
                    }
                };
                var exception = filterContext.Exception;

                var errorLogger = new ErrorLogger(exception);
                errorLogger.Log();

                filterContext.HttpContext.Response.StatusCode = 500;
                filterContext.ExceptionHandled = true;
                base.OnException(filterContext);
            }
            else
            {
                var errType = string.Empty;
                var exception = filterContext.Exception;

                var errorLogger = new ErrorLogger(exception);
                errorLogger.Log();

                filterContext.ExceptionHandled = true;
                filterContext.Result = GetRedirectResultByExceptionType(errType, filterContext);
                base.OnException(filterContext);
            }



           
        }

        private static ActionResult GetRedirectResultByExceptionType(string errType, ExceptionContext exceptionContext)
        {
            var urlHelper = new UrlHelper(exceptionContext.HttpContext.Request.RequestContext);
            var exception = exceptionContext.Exception;
            
            if (exception is UnauthorizedAccessException)
                errType = "unauthorized";
            ActionResult redirectTo=null;
            if (exception is UrlNotFoundException)
                redirectTo = new RedirectToRouteResult("Error404", new RouteValueDictionary());
            else
            {
                redirectTo = new RedirectToRouteResult("Error500", new RouteValueDictionary());
            }
            
            
            return redirectTo;
        }
    }
}
