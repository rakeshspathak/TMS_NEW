using TMS.Domain.Domain;
using TMS.Domain.Entities;

namespace TMS.Business.Interface.Logger
{
    public interface ILogger
    {
        RequestResponseContext FilterContext { get; }

        ControllerAction GetControllerAction(ControllerAction controllerAction);

        void LogRequest(RequestResponseContext filterContext);

        void LogResponse(RequestResponseContext filterContext);
    }
}