using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Collections.Generic;
using System.Linq;
using TMS.Domain.Domain;

namespace TMS.Persistant.MenuDb
{
    public class MenuDbAccess : DatabaseContext
    {
        public static IEnumerable<Menu> RoleWiseMenu(int roleId)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return sqlDatabase.ExecuteSprocAccessor<Menu>(Procedure.spMenu_Get_DetailsByRoleId, roleId).ToList();
            }
        }
    }
}