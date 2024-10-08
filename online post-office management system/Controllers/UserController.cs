using Microsoft.AspNetCore.Mvc;
using Online_Post_Office_Management_System.Models;

namespace Online_Post_Office_Management_System.Controllers
{
    public class UserController : Controller
    {
        // Hiển thị danh sách người dùng
        public IActionResult Index()
        {
            return View();
        }

        // Hiển thị trang tạo người dùng
        public IActionResult Create()
        {
            return View();
        }

        // Xử lý tạo người dùng
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                // Lưu người dùng vào cơ sở dữ liệu
                // Redirect to Index
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // Hiển thị trang chỉnh sửa người dùng theo ID
        public IActionResult Edit(int id)
        {
            // Tìm người dùng theo id
            return View();
        }

        // Xử lý cập nhật thông tin người dùng
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                // Cập nhật thông tin người dùng
                // Redirect to Index
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // Hiển thị trang xóa người dùng theo ID
        public IActionResult Delete(int id)
        {
            // Tìm người dùng theo id
            return View();
        }

        // Xử lý xóa người dùng
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            // Xóa người dùng khỏi cơ sở dữ liệu
            // Redirect to Index
            return RedirectToAction(nameof(Index));
        }
    }
}
