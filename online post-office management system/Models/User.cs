using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Online_Post_Office_Management_System.Models
{
    public class User : IdentityUser
    {
        public string UserId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; }
    }
}
