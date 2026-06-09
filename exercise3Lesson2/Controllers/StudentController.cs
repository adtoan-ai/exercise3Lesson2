using Microsoft.AspNetCore.Mvc;
using exercise3Lesson2.Models;

namespace exercise3Lesson2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            ViewBag.Name = "Nguyễn Văn A";
            ViewData["Age"] = 20;
            Student sv1 = new Student { Major = "CNTT" };
                return View(sv1);
        }
    }
}
