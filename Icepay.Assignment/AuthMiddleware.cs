using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Icepay.Assignment
{
    public class AuthFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string token = context.HttpContext.Request.Headers["x-auth-token"];
            if (!string.IsNullOrEmpty(token))
            {
                if (token == "admin_token")
                {
                    base.OnActionExecuting(context);
                }
                else
                {
                    context.Result = new StatusCodeResult(403);
                }
            }
            else
            {
                context.Result = new StatusCodeResult(401);
            }
        }
    }
}
