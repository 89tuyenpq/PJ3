using Microsoft.AspNetCore.Mvc;
using Online_Post_Office_Management_System.Models;
using Online_Post_Office_Management_System.Services;
using System.Threading.Tasks;

namespace Online_Post_Office_Management_System.Controllers
{
    public class ChargeController : Controller
    {
        private readonly ChargeCalculationService _chargeCalculationService;

        public ChargeController(ChargeCalculationService chargeCalculationService)
        {
            _chargeCalculationService = chargeCalculationService;
        }

        // GET: Charge/Calculate
        public IActionResult Calculate()
        {
            return View();
        }

        // POST: Charge/Calculate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Calculate(ChargeCalculation chargeCalculation)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var totalCharge = await _chargeCalculationService.CalculateTotalChargeAsync(chargeCalculation);
                    return RedirectToAction("ChargeResult", new { totalCharge });
                }
                catch (KeyNotFoundException)
                {
                    ModelState.AddModelError("", "Không tìm thấy phí cho khoảng cách đã nhập.");
                }
            }
            return View(chargeCalculation);
        }

        public IActionResult ChargeResult(decimal totalCharge)
        {
            return View(totalCharge);
        }
    }
}
