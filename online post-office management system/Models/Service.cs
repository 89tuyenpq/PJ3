using System.ComponentModel.DataAnnotations;

namespace Online_Post_Office_Management_System.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }

        [Required]
        public string Name { get; set; }
       
        public string Description { get; set; }
    }
}
