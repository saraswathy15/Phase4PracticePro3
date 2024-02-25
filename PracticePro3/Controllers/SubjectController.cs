using Microsoft.AspNetCore.Mvc;
using PracticePro3.Models;

namespace PracticePro3.Controllers
{
    public class SubjectController : Controller
    {
        List<Subject> subject = new List<Subject>()
        {
            new Subject { Id = 1,Name = "English" },
            new Subject { Id = 2,Name = "Computer" },
            new Subject { Id = 3,Name = "Biology" },
            new Subject { Id = 4,Name = "Physics" },
            new Subject { Id = 5,Name = "Mathematics" },
            new Subject { Id = 1,Name = "English" },
        };
        public IActionResult Index()
        {
            return View(subject);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Subject());
        }
        [HttpPost]
        public IActionResult Create(Subject model)
        {
            if (ModelState.IsValid)
            {
                subject.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
