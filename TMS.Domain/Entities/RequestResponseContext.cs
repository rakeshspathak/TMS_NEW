using System.Collections.Generic;
using TMS.Domain.Domain;

namespace TMS.Domain.Entities
{
    public class RequestResponseContext
    {
        public ControllerAction ControllerAction { get; set; }

        public string URL { get; set; }

        public string LoginCode { get; set; }

        public Dictionary<string, string> Parameters { get; set; }

        public string JsonRequest { get; set; }

        public string JsonResponse { get; set; }
    }
}
