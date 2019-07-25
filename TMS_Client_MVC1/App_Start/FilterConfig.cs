using FluentValidation.Mvc;
using System.Web.Mvc;
using TMS.Client.Mvc.Modules.Exception;
using TMS.Client.Mvc.Modules.Logging;

namespace TMS.Client.Mvc.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new RequestHandler());
            filters.Add(new ExceptionHandler());
            FluentValidationModelValidatorProvider.Configure();
        }
    }
}