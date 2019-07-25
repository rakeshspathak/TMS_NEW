using System;

namespace TMS.Domain.Domain
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte ControllerActionId { get; set; }
        public byte Priority { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
