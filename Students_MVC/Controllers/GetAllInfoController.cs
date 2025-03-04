using Microsoft.AspNetCore.Mvc;
using Students_MVC.Models;

namespace Students_MVC.Controllers
{
    public class GetAllInfoController : Controller
    {
        DBapp _context = new();
        public IActionResult Index()
        {
            List<Trainee> trainees = _context.Trainees.ToList();
            return View();
        }
    }
}
