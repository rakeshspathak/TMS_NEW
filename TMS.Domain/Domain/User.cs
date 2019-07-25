using System.ComponentModel.DataAnnotations;

namespace TMS.Domain.Domain
{
    public class User
    {
        [Display(Name = "SAP Code")]
        public string EmployeeCode { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
