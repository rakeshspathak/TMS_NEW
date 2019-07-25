using System.Web.Mvc;
using TMS.Repository.Interface.Employees;

namespace TMS.Client.Mvc.Controllers
{
    public class TransferController : Controller
    {
        // GET: Transfer


        private readonly IEmployeeRepository employeeRepository;


        public TransferController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string EmployeeCode, string Name)
        {
            ViewBag.Message = "EmployeeName: " + Name + " EmployeeCode: " + EmployeeCode;
            return View();
        }

        // GET: Transfer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Transfer/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string EmployeeCode, string EmployeeName)
        {
            ViewBag.Message = "EmployeeCode: " + EmployeeCode + " EmployeeName: " + EmployeeName;
            return View();
        }


        // GET: Transfer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Transfer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Transfer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Transfer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]

        public JsonResult SearchEmployee(string EmployeeName, string EmployeeCode)
        {
            var employee = employeeRepository.SearchEmployeeById(EmployeeCode);
            return Json(employee, JsonRequestBehavior.AllowGet);
        }


    }
}
