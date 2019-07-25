using TMS.Domain.Enumerations;

namespace TMS.Persistant.LoggerDb
{
    public class ErrorDbAccess : DatabaseContext
    {
        public static void SaveError(string jsonMessage)
        {

            using (DatabaseContext context = new DatabaseContext())
            {
                sqlDatabase.ExecuteNonQuery(Procedure.spLog_Insert_ErrorDetails, ErrorTypeEnum.ApplicationError, jsonMessage);
            }

        }
    }
}
