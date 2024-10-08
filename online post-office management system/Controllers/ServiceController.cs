using Microsoft.AspNetCore.Mvc;
using Online_Post_Office_Management_System.Models;

namespace Online_Post_Office_Management_System.Controllers
{
    public class ServiceController : Controller
    {
        // Hiển thị danh sách dịch vụ
        public IActionResult Index()
        {
            return View();
        }

        // Hiển thị trang tạo dịch vụ
        public IActionResult Create()
        {
            return View();
        }

        // Xử lý tạo dịch vụ
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Service service)
        {
            if (ModelState.IsValid)
            {
                // Lưu dịch vụ vào cơ sở dữ liệu
                // Redirect to Index
                return RedirectToAction(nameof(Index));
            }
            return View(service);
        }

        // Hiển thị trang chỉnh sửa dịch vụ theo ID
        public IActionResult Edit(int id)
        {
            // Tìm dịch vụ theo id
            return View();
        }

        // Xử lý cập nhật thông tin dịch vụ
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Service service)
        {
            if (ModelState.IsValid)
            {
                // Cập nhật thông tin dịch vụ
                // Redirect to Index
                return RedirectToAction(nameof(Index));
            }
            return View(service);
        }

        // Hiển thị trang xóa dịch vụ theo ID
        public IActionResult Delete(int id)
        {
            // Tìm dịch vụ theo id
            return View();
        }

        // Xử lý xóa dịch vụ
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            // Xóa dịch vụ khỏi cơ sở dữ liệu
            // Redirect to Index
            return RedirectToAction(nameof(Index));
        }
    }
}
