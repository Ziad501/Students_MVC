using System.ComponentModel.DataAnnotations.Schema;

namespace Students_MVC.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public Department? Department { get; set; }
        public List<CrsResult>? CrsResults { get; set; } = [];
        public ICollection<Instructor>? Instructors { get; set; } = new HashSet<Instructor>();
    }
}
