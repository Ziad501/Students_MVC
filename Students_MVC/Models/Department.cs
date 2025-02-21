namespace Students_MVC.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public string? Manager { get; set; }

        public ICollection<Trainee> Trainees { get; set; } = new HashSet<Trainee>();
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
