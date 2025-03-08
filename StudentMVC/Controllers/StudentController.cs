using DefinexAttribute;
using Microsoft.AspNetCore.Mvc;
using StudentMVC.Models;

namespace StudentMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student student)
        {
            // Disable automatic model validation
            ModelState.Clear();

            if (RequiredPropertyAttribute.IsValid(student))
            {
                ViewBag.Message = "Student information saved successfully!";
            }
            else
            {
                ViewBag.Message = "Invalid input! Please fill all required fields.";
            }

            return View(student);
        }

    }
}
