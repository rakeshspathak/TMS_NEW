using System;

namespace TMS.Domain.Domain
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public Nullable<int> ParentMenuId { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
    }
}
