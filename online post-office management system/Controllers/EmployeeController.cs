using Microsoft.AspNetCore.Mvc;
using Online_Post_Office_Management_System.Models;

namespace Online_Post_Office_Management_System.Controllers
{
    public class EmployeeController : Controller
    {
        // Hiển thị danh sách nhân viên
        public IActionResult Index()
        {
            return View();
        }

        // Hiển thị trang tạo nhân viên
        public IActionResult Create()
        {
            return View();
        }

        // Xử lý tạo nhân viên
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                // Lưu nhân viên vào cơ sở dữ liệu
                // Redirect to Index
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // Hiển thị trang chỉnh sửa nhân viên theo ID
        public IActionResult Edit(int id)
        {
            // Tìm nhân viên theo id
            return View();
        }

        // Xử lý cập nhật thông tin nhân viên
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                // Cập nhật thông tin nhân viên
                // Redirect to Index
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // Hiển thị trang xóa nhân viên theo ID
        public IActionResult Delete(int id)
        {
            // Tìm nhân viên theo id
            return View();
        }

        // Xử lý xóa nhân viên
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            // Xóa nhân viên khỏi cơ sở dữ liệu
            // Redirect to Index
            return RedirectToAction(nameof(Index));
        }
    }
}
