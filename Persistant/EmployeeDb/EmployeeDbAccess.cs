using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Linq;
using TMS.Domain.Domain;

namespace TMS.Persistant.EmployeeDb
{
    public class EmployeeDbAccess : DatabaseContext
    {

        public static Employee GetEmployee(string employeeCode)
        {

            using (DatabaseContext context = new DatabaseContext())
            {
                return sqlDatabase.ExecuteSprocAccessor<Employee>(Procedure.spEmployee_Get_DetailsById, employeeCode).ToList().FirstOrDefault();
            }
        }
    }
}
