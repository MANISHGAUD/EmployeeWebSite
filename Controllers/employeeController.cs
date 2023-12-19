using EmployeeWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebSite.Controllers
{
    public class employeeController : Controller
    {
        private readonly EmpDbContext dbContext;

        public employeeController(EmpDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(Employee emp)
        {
            dbContext.Employees.Add(emp);
            dbContext.SaveChanges();
            ViewBag.reg = "succes";
            return View();
        }
        [HttpGet]
        public IActionResult Login() 
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Login(Employee emp)
        {
            var check =dbContext.Employees.Where(x=>x.Email == emp.Email && x.Password == emp.Password).FirstOrDefault();
            if (check != null)
            {
                HttpContext.Session.SetString("myName", check.Name);
                var name = HttpContext.Session.GetString("myName");
                ViewBag.name = name;
                ViewBag.msg = "Login Successfully";
               return View("Index");
            }
            ViewBag.error = "Data Not Found";
            return View();
        }
        [HttpGet]
        public IActionResult DigitalSignature() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult DigitalSignature(Employee emp)
        {
            try
            {
                var check = dbContext.Employees.Where(x => x.Email == emp.Email && x.Password == emp.Password).FirstOrDefault();

                if (check != null)
                {

                }
            }
            catch (Exception ex)
            {
               
            }

            return View();
        }
    }
}
