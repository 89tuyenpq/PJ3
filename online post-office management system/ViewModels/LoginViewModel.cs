using System.ComponentModel.DataAnnotations;

namespace Online_Post_Office_Management_System.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; } // Thêm thuộc tính này
    }
}
