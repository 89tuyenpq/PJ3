using System.ComponentModel.DataAnnotations;

namespace Online_Post_Office_Management_System.Models
{
    public class Package
    {
        public int PackageId { get; set; }
        public string PackageName { get; set; }

        [Required]
        public double Weight { get; set; }

        [Required]
        public double Distance { get; set; }

        public string Dimensions { get; set; }
        public double CalculateCharge(double distance, double weight)
        {
            // Logic to calculate charges based on distance and weight
            return (distance * weight) * 0.1; // Ví dụ đơn giản, bạn có thể thay đổi theo yêu cầu
        }
    }
}
