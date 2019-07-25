using System;

namespace TMS.Domain.Entities
{
    public class ExceptionLogger
    {
        public string EmployeeCode { get; set; }

        public string ExceptionMessage { get; set; }

        public string ControllerName { get; set; }

        public string ActionName { get; set; }

        public string InnerException { get; set; }

        public string ExceptionStackTrace { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
