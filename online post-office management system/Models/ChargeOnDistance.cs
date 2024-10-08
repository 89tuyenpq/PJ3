using System.ComponentModel.DataAnnotations;

namespace Online_Post_Office_Management_System.Models
{
    public class ChargeOnDistance
    {
        public int Id { get; set; }

        [Required]
        public double Distance { get; set; }

        [Required]
        public double Weight { get; set; } // Đảm bảo thuộc tính này được định nghĩa

        [Required]
        public decimal Amount { get; set; }
    }
}
