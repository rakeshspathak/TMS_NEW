using System.Web.Mvc;
using TMS.Domain.Domain;
using TMS.Repository.Interface.Employees;

namespace TMS.Client.Mvc.Controllers
{
    [Authorize]
    //[AccessAuthentication]
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        public ActionResult Index()
        {
            var employee = _employeeRepository.GetEmployeeDetails(HttpContext.User.Identity.Name);

            return View(employee);
        }

        [HttpGet]
        public ActionResult Product()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Product(Product product)
        {
            return View();
        }
    }
}