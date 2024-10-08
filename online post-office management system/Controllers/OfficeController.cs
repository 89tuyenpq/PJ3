using Microsoft.AspNetCore.Mvc;
using Online_Post_Office_Management_System.Models;

namespace Online_Post_Office_Management_System.Controllers
{
    public class OfficeController : Controller
    {
        // Hiển thị danh sách văn phòng
        public IActionResult Index()
        {
            return View();
        }

        // Hiển thị trang tạo văn phòng
        public IActionResult Create()
        {
            return View();
        }

        // Xử lý tạo văn phòng
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Office office)
        {
            if (ModelState.IsValid)
            {
                // Lưu văn phòng vào cơ sở dữ liệu
                // Redirect to Index
                return RedirectToAction(nameof(Index));
            }
            return View(office);
        }

        // Hiển thị trang chỉnh sửa văn phòng theo ID
        public IActionResult Edit(int id)
        {
            // Tìm văn phòng theo id
            return View();
        }

        // Xử lý cập nhật thông tin văn phòng
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Office office)
        {
            if (ModelState.IsValid)
            {
                // Cập nhật thông tin văn phòng
                // Redirect to Index
                return RedirectToAction(nameof(Index));
            }
            return View(office);
        }

        // Hiển thị trang xóa văn phòng theo ID
        public IActionResult Delete(int id)
        {
            // Tìm văn phòng theo id
            return View();
        }

        // Xử lý xóa văn phòng
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            // Xóa văn phòng khỏi cơ sở dữ liệu
            // Redirect to Index
            return RedirectToAction(nameof(Index));
        }
    }
}
