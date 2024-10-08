using System;
using System.ComponentModel.DataAnnotations;

namespace Online_Post_Office_Management_System.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [Required]
        public string Comment { get; set; }
        public string Title { get; set; }

        [Required]
        public DateTime DateSubmitted { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
        public string SubmittedBy { get; set; }
        public string Content { get; set; }
    }
}
