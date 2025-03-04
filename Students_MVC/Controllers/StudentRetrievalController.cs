using Microsoft.AspNetCore.Mvc;
using Students_MVC.MdelView;
using Students_MVC.Models;

namespace Students_MVC.Controllers
{
    public class StudentRetrievalController : Controller
    {
        DBapp _context= new ();

        public IActionResult GetStudentById(int id)
        {
            var student = _context.Trainees.Where(s=> s.Id == id).Select(s=> new StudentResults
            {
                StudentId = s.Id,
                StudentName = s.TraineeName?? "unknow",
                Subject = s.CrsResults!.FirstOrDefault() != null ? s.CrsResults.FirstOrDefault()!.Course.CourseName : "Not Enrolled",

                Marks = s.CrsResults!.FirstOrDefault() != null ? s.CrsResults.FirstOrDefault()!.Degree : 0
            }).FirstOrDefault();
            if(student == null)
            {
                return NotFound("student not found");
            }
            return View("GetStudentById", student);
        }
    }
}
