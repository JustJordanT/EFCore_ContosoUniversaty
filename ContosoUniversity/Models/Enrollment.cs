namespace ContosoUniversity.Models
{
    public enum grade
    {
        A, B , C, D, F
    }


    public class enrollment
    {
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public grade? Grade { get; set; }
        
        public course Course { get; set; }
        public student Student { get; set; }
    }
}