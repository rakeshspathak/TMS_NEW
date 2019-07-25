using System.Web.Mvc;
using TMS.Client.Mvc.Modules.Constant;
using TMS.Domain.Entities;
using TMS.Repository.Interface.Menus;

namespace TMS.Client.Mvc.Controllers
{
    [Authorize]
    public class MenuController : Controller
    {
        private readonly IMenuAccessRepository _menuAccessRepository;

        public MenuController(IMenuAccessRepository menuAccessRepository)
        {
            this._menuAccessRepository = menuAccessRepository;
        }
        public ActionResult GetRoleWiseMenu()
        {
            int roleId = ((EmployeeRole)Session["EmployeeRole"]).CurrentRole;
            var menuList = _menuAccessRepository.RoleWiseMenu(roleId);
            return PartialView(Route.PARTIAL_MENU, menuList);
        }
    }
}