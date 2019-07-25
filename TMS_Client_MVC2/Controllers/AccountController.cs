using System;
using System.Net;
using System.Security.Claims;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TMS.Client.Mvc.Modules.Constant;
using TMS.Client.Mvc.Modules.MyHcl;
using TMS.Domain.Domain;
using TMS.Repository.Interface.Employees;
using TMS.Repository.Interface.RoleRepository;

namespace TMS.Client.Mvc.Controllers
{
    public class AccountController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IRoleRepository _roleRepository;

        public AccountController(IEmployeeRepository employeeRepository, IRoleRepository roleRepository)
        {
            _employeeRepository = employeeRepository;
            _roleRepository = roleRepository;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User userModel)
        {
            if (_employeeRepository.ValidateUser(userModel.EmployeeCode, userModel.Password))
            {
                AuthenticationTicketProvider(userModel.EmployeeCode);

                var employeeRoles = _roleRepository.GetUserRoles(userModel.EmployeeCode, 0);

                if (Session["EmployeeRole"] == null)
                {
                    Session["EmployeeRole"] = employeeRoles;
                }

                return RedirectToAction(employeeRoles.Action, employeeRoles.Controller);
            }

            return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
        }

        [HttpGet]
        public ActionResult SingleSignOn()
        {
            ClaimsPrincipal claimsPrincipal = Thread.CurrentPrincipal as ClaimsPrincipal;

            string emailAlias = new MyHclCredentials(claimsPrincipal).GetAuthenticatedEmployeeDetails();

            if (_employeeRepository.ValidateUser(emailAlias, null) && emailAlias != null)
            {
                AuthenticationTicketProvider(emailAlias);
                return RedirectToAction(Route.VIEW_INDEX, Route.CONTROLLER_HOME);
            }

            //return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            return Content("Unauthorized access : " + emailAlias);
        }


        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction(Route.ACTION_LOGIN);
        }

        private void AuthenticationTicketProvider(string employeeCode)
        {
            FormsAuthentication.SetAuthCookie(employeeCode, false);

            var authenticationTicket = new FormsAuthenticationTicket(1, employeeCode, DateTime.Now, DateTime.Now.AddMinutes(10), false, "");
            var encryptedTicket = FormsAuthentication.Encrypt(authenticationTicket);
            var authenticationCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);

            HttpContext.Response.Cookies.Add(authenticationCookie);
        }
    }
}