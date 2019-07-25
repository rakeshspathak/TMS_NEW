using Newtonsoft.Json;
using System.Linq;
using System.Web.Mvc;
using TMS.Business.Interface.Logger;
using TMS.Client.Mvc.Modules.Constant;

namespace TMS.Client.Mvc.Modules.Logging
{
    public class RequestHandler : FilterAttribute, IActionFilter
    {
        private ILogger _logger;
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Request.HttpMethod == Common.HTTP_GET)
                return;

            _logger = DependencyResolver.Current.GetService<ILogger>();

            SetRequestContext(filterContext);

            if (_logger.FilterContext.ControllerAction == null)
                return;

            if (!_logger.FilterContext.ControllerAction.IsLogEnabled)
                return;

            _logger.FilterContext.JsonRequest = JsonConvert.SerializeObject(_logger.FilterContext);

            _logger.LogRequest(_logger.FilterContext);
        }

        private void SetRequestContext(ActionExecutingContext filterContext)
        {
            _logger.FilterContext.ControllerAction.Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            _logger.FilterContext.ControllerAction.Action = filterContext.ActionDescriptor.ActionName;
            _logger.FilterContext.URL = "";
            _logger.FilterContext.LoginCode = filterContext.HttpContext.User.Identity.Name;
            _logger.FilterContext.Parameters = filterContext.HttpContext.Request.Form.AllKeys
                .ToDictionary(x => x, x => filterContext.HttpContext.Request.Form[x]);
            _logger.FilterContext.ControllerAction = _logger.GetControllerAction(_logger.FilterContext.ControllerAction);
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.HttpContext.Request.HttpMethod == Common.HTTP_GET)
                return;

            if (_logger.FilterContext.ControllerAction == null)
                return;

            if (!_logger.FilterContext.ControllerAction.IsLogEnabled)
                return;

            _logger.FilterContext.JsonResponse = JsonConvert.SerializeObject(filterContext.Result);

            _logger.LogResponse(_logger.FilterContext);
        }

    }
}