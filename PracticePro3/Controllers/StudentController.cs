using Microsoft.AspNetCore.Mvc;
using PracticePro3.Models;

namespace PracticePro3.Controllers
{
    public class StudentController : Controller
    {
        List<Student> student = new List<Student>()
        {
            new Student { Id=1,Name = "Charu", Class = "8A", Age = 13, Address = "No:14 French Colony"},
            new Student { Id=2,Name = "Preetha", Class = "9A", Age = 15, Address = "No:10 Gandhi Road"},
            new Student { Id=3,Name = "Bavi", Class = "12B", Age = 16, Address = "No:22 Chruch Park"},
            new Student { Id=4,Name = "Sanju", Class = "11A", Age = 15, Address = "No:43 North Street"},
            new Student { Id=5,Name = "Ranjali", Class = "10A", Age = 14, Address = "No:82 East Street"},
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
