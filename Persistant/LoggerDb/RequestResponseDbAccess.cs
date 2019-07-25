using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Linq;
using TMS.Domain.Domain;
using TMS.Domain.Entities;

namespace TMS.Persistant.LoggerDb
{
    public class RequestResponseDbAccess : DatabaseContext
    {

        public static ControllerAction GetControllerAction(ControllerAction controllerAction)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                return sqlDatabase.ExecuteSprocAccessor<ControllerAction>(Procedure.spControllerAction_Get_ByNames, controllerAction.Controller, controllerAction.Action).FirstOrDefault();
            }
        }

        public static void LogRequest(RequestResponseContext filterContext)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                sqlDatabase.ExecuteNonQuery(Procedure.spLog_Insert_Request, filterContext.ControllerAction.Id, filterContext.JsonRequest, filterContext.LoginCode);
            }
        }

        public static void LogResponse(RequestResponseContext filterContext)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                sqlDatabase.ExecuteNonQuery(Procedure.spLog_Update_Response, filterContext.ControllerAction.Id, filterContext.JsonResponse);
            }
        }
    }
}
