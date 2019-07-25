using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Domain.Domain;

namespace TMS.Domain.Entities
{
    public class EmployeeRole
    {
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public List<Role> Roles { get; set; }
        public byte CurrentRole { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
    }
}
