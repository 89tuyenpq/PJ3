using System.ComponentModel.DataAnnotations;

namespace Online_Post_Office_Management_System.Models
{
    public class Role
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
