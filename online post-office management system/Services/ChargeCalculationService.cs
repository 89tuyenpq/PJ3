using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Online_Post_Office_Management_System.Models;

namespace Online_Post_Office_Management_System.Services
{
    public class ChargeCalculationService
    {
        // Ví dụ: một dictionary lưu trữ các mức phí theo khoảng cách
        private readonly Dictionary<int, decimal> _chargeRates;

        public ChargeCalculationService()
        {
            // Khởi tạo các mức phí cho khoảng cách
            _chargeRates = new Dictionary<int, decimal>
            {
                { 1, 1000 }, // Phí cho khoảng cách 1 km
                { 2, 2000 }, // Phí cho khoảng cách 2 km
                // Thêm các mức phí khác ở đây
            };
        }

        public async Task<decimal> CalculateTotalChargeAsync(ChargeCalculation chargeCalculation)
        {
            // Giả sử bạn cần phải tìm mức phí cho khoảng cách đã nhập
            if (_chargeRates.TryGetValue(Convert.ToInt32(chargeCalculation.Distance), out decimal charge))
            {
                // Chuyển đổi trọng lượng từ double sang decimal
                decimal weight = Convert.ToDecimal(chargeCalculation.Weight);
                // Tính phí tổng
                return charge * weight;
            }

            // Ném ngoại lệ nếu không tìm thấy mức phí cho khoảng cách
            throw new KeyNotFoundException("Không tìm thấy mức phí cho khoảng cách đã nhập.");
        }
    }
}
