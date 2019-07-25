using System.Collections.Generic;
using TMS.Domain.Domain;
using TMS.Persistant.MenuDb;
using TMS.Repository.Interface.Menus;

namespace TMS.Dependency.Data.Menus
{
    public class MenuAccessRepository : IMenuAccessRepository
    {

        public IEnumerable<Menu> RoleWiseMenu(int roleId)
        {
            return MenuDbAccess.RoleWiseMenu(roleId);
        }

        //public IEnumerable<Menu> RoleWiseMenu(int statusId, string employeeCode)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}