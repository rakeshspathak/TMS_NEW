using System.Collections.Generic;
using TMS.Domain;
using TMS.Domain.Domain;

namespace TMS.Repository.Interface.Menus
{
    public interface IMenuAccessRepository
    {
        IEnumerable<Menu> RoleWiseMenu(int roleId);
    }
}
