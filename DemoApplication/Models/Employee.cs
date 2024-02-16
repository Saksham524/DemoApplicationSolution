using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApplication.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }
        //public string? Department { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        // Navigation property for the related Department
        public Department? Department { get; set; }

    }
}
