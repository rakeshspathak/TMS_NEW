namespace TMS.Domain.Domain
{
    public class ControllerAction
    {
        public int Id { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        public bool IsLogEnabled { get; set; }
    }
}
