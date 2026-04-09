using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment3.Models
{
    public class EventRegistration
    {
        [Required]
        [MinLength(3, ErrorMessage = "Full Name Required")]
        public string FullName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Enter a Valid Email Address")]

        public string Email {  get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Cannot Exceed 20 Characters")]
        public string EventCode { get; set; }

        [Required]
        [Range(1,10, ErrorMessage = "Tickets Must be Between 1 and 10")]
        public int Tickets { get; set; }

    }
}
