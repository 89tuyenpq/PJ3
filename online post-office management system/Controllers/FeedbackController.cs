using Microsoft.AspNetCore.Mvc;
using Online_Post_Office_Management_System.Models;

namespace Online_Post_Office_Management_System.Controllers
{
    public class FeedbackController : Controller
    {
        // Hiển thị danh sách phản hồi
        public IActionResult Index()
        {
            return View();
        }

        // Hiển thị trang tạo phản hồi
        public IActionResult Create()
        {
            return View();
        }

        // Xử lý tạo phản hồi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                // Lưu phản hồi vào cơ sở dữ liệu
                // Redirect to Index
                return RedirectToAction(nameof(Index));
            }
            return View(feedback);
        }

        // Hiển thị thông tin phản hồi theo ID
        public IActionResult Details(int id)
        {
            // Tìm phản hồi theo id
            return View();
        }
    }
}
