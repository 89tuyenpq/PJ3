using Online_Post_Office_Management_System.Models;

namespace Online_Post_Office_Management_System.Services
{
    public class ChargeCalculationService_Old
    {
        // Phí cơ bản cho tính toán
        private const double BaseRate = 5.0;

        // Tính toán phí dựa trên khoảng cách và trọng lượng
        public double CalculateCharge(double distance, double weight)
        {
            // Kiểm tra giá trị đầu vào
            if (distance < 0 || weight < 0)
            {
                throw new ArgumentException("Distance and weight must be non-negative.");
            }

            // Logic tính phí
            double charge = BaseRate + (0.5 * weight) + (0.1 * distance); // Ví dụ tính toán
            return charge;
        }

        // Tính phí theo một gói hàng cụ thể
        public double CalculateChargeForPackage(Package package)
        {
            return CalculateCharge(package.Distance, package.Weight);
        }
    }
}
