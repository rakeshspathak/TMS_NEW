using TMS.Domain.Entities;

namespace TMS.Repository.Interface.RoleRepository
{
    public interface IRoleRepository
    {
        EmployeeRole GetUserRoles(string employeeCode, int roleId);
    }
}
