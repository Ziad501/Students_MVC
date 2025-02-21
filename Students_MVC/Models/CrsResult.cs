using System.ComponentModel.DataAnnotations.Schema;

namespace Students_MVC.Models
{
    public class CrsResult
    {
        public int CrsResultId { get; set; }
        [ForeignKey("Trainee")]
        public int TraineeId { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public int Degree { get; set; }

        public Trainee? Trainee { get; set; }
        public Course? Course { get; set; }
    }
}
