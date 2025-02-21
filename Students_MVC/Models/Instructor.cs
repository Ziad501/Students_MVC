using System.ComponentModel.DataAnnotations.Schema;

namespace Students_MVC.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string? InstructorName { get; set; }
        public string? Image { get; set; }
        public int Salary { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course? Course { get; set; }
        public Department? Department { get; set; }
    }
}
