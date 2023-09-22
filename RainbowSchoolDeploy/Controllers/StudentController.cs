using Microsoft.AspNetCore.Mvc;
using RainbowSchoolDeploy.Models;

namespace RainbowSchoolDeploy.Controllers
{
    public class StudentController : Controller
    {
        List<Student> student = new List<Student>()
        {
            new Student { Id = 1, Name = "Sam", Class = "5", Age = 10, Address = "Some"},
            new Student { Id = 2, Name = "Ram", Class = "6", Age = 11, Address = "XYZ"},
            new Student { Id = 3, Name = "Shyam", Class = "7", Age = 12, Address = "ABC"},
        };
        public IActionResult Index()
        {
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                student.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
