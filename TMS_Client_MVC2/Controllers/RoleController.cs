using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using TMS.Client.Mvc.Modules.Constant;
using TMS.Domain.Entities;
using TMS.Repository.Interface.RoleRepository;

namespace TMS.Client.Mvc.Controllers
{
    [Authorize]
    public class RoleController : Controller
    {
        private readonly IRoleRepository _roleRepository;

        public RoleController(IRoleRepository roleRepository)
        {
            this._roleRepository = roleRepository;
        }

        public ActionResult UserRole()
        {

            if (Session["EmployeeRole"] != null)
            {
                return PartialView(Route.PARTIAL_ROLE, Session["EmployeeRole"] as EmployeeRole);
            }

            return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);

        }

        public ActionResult ChangeRole(int id)
        {
            var roles = _roleRepository.GetUserRoles(HttpContext.User.Identity.Name, id);
            Session["EmployeeRole"] = roles;

            return RedirectToAction(roles.Action,roles.Controller);
        }
    }
}