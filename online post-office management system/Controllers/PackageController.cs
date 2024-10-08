using Microsoft.AspNetCore.Mvc;
using Online_Post_Office_Management_System.Models;

namespace Online_Post_Office_Management_System.Controllers
{
    public class PackageController : Controller
    {
        // Hiển thị danh sách gói hàng
        public IActionResult Index()
        {
            return View();
        }

        // Hiển thị trang tạo gói hàng
        public IActionResult Create()
        {
            return View();
        }

        // Xử lý tạo gói hàng
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Package package)
        {
            if (ModelState.IsValid)
            {
                // Lưu gói hàng vào cơ sở dữ liệu
                // Redirect to Index
                return RedirectToAction(nameof(Index));
            }
            return View(package);
        }

        // Hiển thị trang chỉnh sửa gói hàng theo ID
        public IActionResult Edit(int id)
        {
            // Tìm gói hàng theo id
            return View();
        }

        // Xử lý cập nhật thông tin gói hàng
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Package package)
        {
            if (ModelState.IsValid)
            {
                // Cập nhật thông tin gói hàng
                // Redirect to Index
                return RedirectToAction(nameof(Index));
            }
            return View(package);
        }

        // Hiển thị trang xóa gói hàng theo ID
        public IActionResult Delete(int id)
        {
            // Tìm gói hàng theo id
            return View();
        }

        // Xử lý xóa gói hàng
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            // Xóa gói hàng khỏi cơ sở dữ liệu
            // Redirect to Index
            return RedirectToAction(nameof(Index));
        }
    }
}
