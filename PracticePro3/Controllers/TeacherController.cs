using Microsoft.AspNetCore.Mvc;
using PracticePro3.Models;
using System.Xml.Linq;

namespace PracticePro3.Controllers
{
    public class TeacherController : Controller
    {
        List<Teacher> teacher = new List<Teacher>()
        {
            new Teacher { Id = 1, Name ="Mr.Sathish", TeachingSubject ="Biology"},
            new Teacher { Id = 2, Name ="Mr.Suresh", TeachingSubject ="Physics"},
            new Teacher { Id = 3, Name ="Mr.Muthu", TeachingSubject ="Mathematics"},
            new Teacher { Id = 4, Name ="Ms.SivaRanjani", TeachingSubject ="English"},
            new Teacher { Id = 5, Name ="Ms.Bharathi", TeachingSubject ="Computer"},
        };
        public IActionResult Index()
        {
            return View(teacher);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Teacher());
        }
        [HttpPost]
        public IActionResult Create (Teacher model)
        {
            if(ModelState.IsValid)
            {
                teacher.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
