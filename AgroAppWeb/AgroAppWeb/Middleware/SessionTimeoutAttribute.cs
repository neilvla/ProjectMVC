using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace AgroAppWeb.Middleware
{
    public class SessionTimeoutAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            User u = context.HttpContext.Session.GetObject<User>("UserSession");

            //if not in DB
            if (u == null)
            {
                RouteValueDictionary redirectTargetDictionary = new RouteValueDictionary();
                redirectTargetDictionary.Add("action", "LogIn");
                redirectTargetDictionary.Add("controller", "Authentication");

                context.Result = new RedirectToRouteResult(redirectTargetDictionary);
            }

            base.OnActionExecuting(context);
        }
    }
}
