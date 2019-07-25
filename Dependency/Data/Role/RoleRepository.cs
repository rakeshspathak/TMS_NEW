using TMS.Domain.Entities;
using TMS.Persistant.RoleDb;
using TMS.Repository.Interface.RoleRepository;

namespace TMS.Dependency.Business.Data.Role
{
    public class RoleRepository : IRoleRepository
    {
        public EmployeeRole GetUserRoles(string employeeCode, int roleId)
        {
            return RoleDbAccess.GetUserDetails(employeeCode, roleId);
        }
    }
}
