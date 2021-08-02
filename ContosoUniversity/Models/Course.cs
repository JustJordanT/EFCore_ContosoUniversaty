using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class course
    {
        //This is a feature that helps with PK
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }
        public string Title { get; set; }
        public double Credits { get; set; }
    }
}