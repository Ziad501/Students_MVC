using Microsoft.AspNetCore.Mvc;
using Students_MVC.MdelView;
using Students_MVC.Models;

namespace Students_MVC.Controllers
{
    public class GetAllInfoController : Controller
    {
        DBapp _context = new();
        public IActionResult Students()
        {
            List<StudentResults> trainees = _context.Trainees
                .SelectMany(p => p.CrsResults.Select(cr => new StudentResults
                {
                    StudentId = p.Id,
                    StudentName = p.TraineeName ?? "Unknown",
                    Subject = cr.Course.CourseName,
                    Marks = cr.Degree
                }))
                .ToList();

            return View(trainees);
        }
    }
}
