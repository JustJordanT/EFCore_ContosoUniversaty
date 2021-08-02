using System;

namespace ContosoUniversity.Models
{
    public class student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}