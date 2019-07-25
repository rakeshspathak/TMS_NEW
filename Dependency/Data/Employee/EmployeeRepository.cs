using TMS.Domain.Domain;
using TMS.Persistant.EmployeeDb;
using TMS.Repository.Interface.Employees;

namespace TMS.Dependency.Data.Employees
{
    public class EmployeeRepository : IEmployeeRepository// Repository<Employee>,
    {

        public Employee GetEmployeeDetails(string employeeCode)
        {
            return EmployeeDbAccess.GetEmployee(employeeCode);
        }       
        public bool ValidateUser(string employeeCode, string password)
        {
            return true;
        }
    }
}
