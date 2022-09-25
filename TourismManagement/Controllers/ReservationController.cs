using Microsoft.AspNetCore.Mvc;

namespace TourismManagement.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
