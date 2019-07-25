using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace TMS.Client.Mvc.Modules.Authentication
{
    public class AccessAuthentication : FilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            if (!(filterContext.HttpContext.User.Identity.IsAuthenticated))
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            if (filterContext.HttpContext.User == null || filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new ViewResult()
                {
                    ViewName = "_Unauthorized"
                };
            }
        }
    }
}