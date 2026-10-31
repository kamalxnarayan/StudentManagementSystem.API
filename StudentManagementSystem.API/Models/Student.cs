
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.API.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Student name is required")]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; } = string.Empty;

        [Range(16, 100, ErrorMessage = "Age must be between 16 and 100")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Course is required")]
        public string Course { get; set; } = string.Empty;
    }
}
