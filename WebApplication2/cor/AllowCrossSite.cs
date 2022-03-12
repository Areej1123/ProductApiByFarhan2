

using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Mvc;

public class AllowCrossSiteJsonAttribute : System.Web.Mvc.ActionFilterAttribute, System.Web.Mvc.IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationContext filterContext)
    {
        filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Origin", "*");
    }

}