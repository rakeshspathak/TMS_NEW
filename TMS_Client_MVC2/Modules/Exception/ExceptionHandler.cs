using System;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using TMS.Client.Mvc.Modules.Constant;
using TMS.Repository.Interface.ErrorRepository;

namespace TMS.Client.Mvc.Modules.Exception
{
    public class ExceptionHandler : FilterAttribute, IExceptionFilter
    {

        private IErrorRepository _errorRepository;

        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                _errorRepository = DependencyResolver.Current.GetService<IErrorRepository>();
                SetLogger(filterContext);
                string jsonMessage = JsonConvert.SerializeObject(_errorRepository.FilterContext);
                _errorRepository.SaveExceptionDetails(jsonMessage);

                filterContext.Result = new ViewResult()
                {
                    ViewName = Route.PARTIAL_ERROR
                };

                filterContext.ExceptionHandled = true;
            }
        }

        private void SetLogger(ExceptionContext filterContext)
        {
            _errorRepository.FilterContext.EmployeeCode = HttpContext.Current.User.Identity.Name;
            _errorRepository.FilterContext.ControllerName = filterContext.RouteData.Values[Common.CONTROLLER].ToString();
            _errorRepository.FilterContext.ActionName = filterContext.RouteData.Values[Common.ACTION].ToString();
            _errorRepository.FilterContext.ExceptionMessage = filterContext.Exception.Message;
            _errorRepository.FilterContext.InnerException = filterContext.Exception.InnerException != null ? filterContext.Exception.InnerException.ToString() : "Inner exception";
            _errorRepository.FilterContext.ExceptionStackTrace = filterContext.Exception.StackTrace;
            _errorRepository.FilterContext.CreatedDate = DateTime.Now;
        }
    }
}