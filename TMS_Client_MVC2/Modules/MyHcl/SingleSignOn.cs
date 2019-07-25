using System.Linq;
using System.Security.Claims;

namespace TMS.Client.Mvc.Modules.MyHcl
{
    public class MyHclCredentials
    {
        ClaimsPrincipal _claimsPrincipal;
        public MyHclCredentials(ClaimsPrincipal claimsPrincipal)
        {
            _claimsPrincipal = claimsPrincipal;
        }
        public string GetAuthenticatedEmployeeDetails()
        {
            if (_claimsPrincipal != null && _claimsPrincipal.Identity.IsAuthenticated)
                return GetSamAccountName();

            return null;
        }

        //private string GetEmployeeCode()
        //{
        //    return (from c in _claimsPrincipal.Claims
        //            where c.Type.Contains("sapcode")
        //            select c.Value).Single();
        //}

        //private string GetEntityId()
        //{
        //    return (from c in _claimsPrincipal.Claims
        //            where c.Type.Contains("entityid")
        //            select c.Value).Single();
        //}

        private string GetSamAccountName()
        {
            return (from c in _claimsPrincipal.Claims
                    where c.Type.Contains("samaccountname")
                    select c.Value).Single();
        }
    }
}