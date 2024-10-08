using System.ComponentModel.DataAnnotations;

namespace Online_Post_Office_Management_System.Models
{
    public class ChargeCalculation
    {
        [Required(ErrorMessage = "Khoảng cách là bắt buộc.")]
        public double Distance { get; set; }

        [Required(ErrorMessage = "Trọng lượng là bắt buộc.")]
        public double Weight { get; set; }

        public double CalculateCharge()
        {
            // Logic to calculate charges based on distance and weight
            double baseRate = 5.0; // phí cơ bản
            double charge = baseRate + (0.5 * Weight) + (0.1 * Distance); // công thức tính phí
            return charge;
        }
    }
}
