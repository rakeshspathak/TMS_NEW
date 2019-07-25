using TMS.Domain.Entities;
using TMS.Persistant.LoggerDb;
using TMS.Repository.Interface.ErrorRepository;

namespace TMS.Dependency.Business.Data.Error
{
    public class ErrorRepository : IErrorRepository
    {
        public ErrorRepository()
        {
            FilterContext = new ExceptionLogger();
        }
        public ExceptionLogger FilterContext { get; }
        public void SaveExceptionDetails(string jsonMessage)
        {
            ErrorDbAccess.SaveError(jsonMessage);
        }
    }
}