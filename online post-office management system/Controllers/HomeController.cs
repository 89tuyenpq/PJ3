using Microsoft.AspNetCore.Mvc;

namespace Online_Post_Office_Management_System.Controllers
{
    public class HomeController : Controller
    {
        // Hiển thị trang chính của hệ thống
        public IActionResult Index()
        {
            return View();
        }

        // Hiển thị trang chính sách bảo mật
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
