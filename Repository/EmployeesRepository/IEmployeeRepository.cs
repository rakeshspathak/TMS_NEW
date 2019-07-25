using TMS.Domain;
using TMS.Domain.Domain;

namespace TMS.Repository.Interface.Employees
{
    public interface IEmployeeRepository
    {
        bool ValidateUser(string employeeCode, string password);

        Employee GetEmployeeDetails(string employeeCode);       
    }
}
