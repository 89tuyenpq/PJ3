using System.ComponentModel.DataAnnotations;

namespace Online_Post_Office_Management_System.Models
{
    public class Office
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }
        public string OfficeName { get; set; }
        public int OfficeId { get; set; }
        public string Location { get; set; }
    }
}
