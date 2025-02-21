using System.ComponentModel.DataAnnotations.Schema;

namespace Students_MVC.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string? TraineeName { get; set; }
        public string? Image { get; set; }
        public string? Address { get; set; }
        public int Grade { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        public List<CrsResult>? CrsResults { get; set; } = [];
    }
}
