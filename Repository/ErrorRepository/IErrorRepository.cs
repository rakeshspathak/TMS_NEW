using TMS.Domain.Entities;

namespace TMS.Repository.Interface.ErrorRepository
{
    public interface IErrorRepository
    {
        ExceptionLogger FilterContext { get; }
        void SaveExceptionDetails(string jsonMessage);
    }
}
