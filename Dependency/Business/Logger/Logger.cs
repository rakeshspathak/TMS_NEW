using TMS.Business.Interface.Logger;
using TMS.Domain.Domain;
using TMS.Domain.Entities;
using TMS.Persistant.LoggerDb;

namespace TMS.Dependency.Business.Business.Logger
{
    public class Logger : ILogger
    {
        public Logger()
        {
            FilterContext = new RequestResponseContext();
            FilterContext.ControllerAction = new ControllerAction();
        }

        public RequestResponseContext FilterContext { get; }

        public ControllerAction GetControllerAction(ControllerAction controllerAction)
        {
            return RequestResponseDbAccess.GetControllerAction(controllerAction);
        }

        public void LogRequest(RequestResponseContext filterContext)
        {
            RequestResponseDbAccess.LogRequest(filterContext);
        }

        public void LogResponse(RequestResponseContext filterContext)
        {
            RequestResponseDbAccess.LogResponse(filterContext);

        }
    }
}