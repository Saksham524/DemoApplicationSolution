using System.ComponentModel.DataAnnotations;

namespace DemoApplication.Models
{
    public class Department
    {
        [Key]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        [Display(Name = "Department")]
        public string? DepartmentName { get; set; }

        // Navigation property for the related Employees
        public List<Employee>? Employees { get; set; }

    }
}
