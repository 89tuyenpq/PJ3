using System;

namespace Online_Post_Office_Management_System.Models
{
    public class ChargeCalculationResult
    {
        public double Distance { get; set; } // Đảm bảo thuộc tính này tồn tại
        public double Weight { get; set; }
        public decimal Amount { get; set; }

        // Các thuộc tính khác nếu cần
    }
}
