using System;
using System.Collections.Generic;
using System.Data;
using TMS.Domain.Domain;
using TMS.Domain.Entities;

namespace TMS.Persistant.RoleDb
{
    public class RoleDbAccess : DatabaseContext
    {
        public static EmployeeRole GetUserDetails(string employeeCode, int roleId)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                object[] parameters = new object[] { employeeCode, roleId };
                return GetUserDetails(parameters);
            }
        }

        private static EmployeeRole GetUserDetails(object[] parameters)
        {
            var employeeRole = new EmployeeRole();
            DataSet dsUserDetails = sqlDatabase.ExecuteDataSet(Procedure.spEmployee_Get_RoleByEmployeeCode, parameters);

            if (dsUserDetails != null && dsUserDetails.Tables.Count > 0)
            {
                employeeRole.Roles = SetUserRoles(dsUserDetails.Tables[0]);

                if (dsUserDetails.Tables.Count > 1)
                    SetUserDetails(employeeRole, dsUserDetails.Tables[1]);
            }
            return employeeRole;
        }

        private static List<Role> SetUserRoles(DataTable dtUserDetails)
        {
            var roles = new List<Role>();
            foreach (DataRow dataRow in dtUserDetails.Rows)
            {
                var role = new Role
                {
                    Id = Convert.ToByte(dataRow["RoleId"]),
                    Name = dataRow["RoleName"].ToString()
                };
                roles.Add(role);
            }
            return roles;
        }

        private static void SetUserDetails(EmployeeRole employeeRole, DataTable dtUserRoles)
        {
            employeeRole.EmployeeCode = dtUserRoles.Rows[0]["EmployeeCode"].ToString();
            employeeRole.EmployeeName = dtUserRoles.Rows[0]["EmployeeName"].ToString();
            employeeRole.CurrentRole = Convert.ToByte(dtUserRoles.Rows[0]["CurrentRoleId"]);
            employeeRole.Controller = dtUserRoles.Rows[0]["Controller"].ToString();
            employeeRole.Action = dtUserRoles.Rows[0]["Action"].ToString();
        }
    }
}
