using System;
using System.Linq;
using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
   public static class dbInitializer
    {
        public static void Initialize(schoolContext context)
        {
            //The EnsureCreated method is used to automatically create the database.
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new student[]
            {
            new student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new course[]
            {
            new course{CourseId=1050,Title="Chemistry",Credits=3},
            new course{CourseId=4022,Title="Microeconomics",Credits=3},
            new course{CourseId=4041,Title="Macroeconomics",Credits=3},
            new course{CourseId=1045,Title="Calculus",Credits=4},
            new course{CourseId=3141,Title="Trigonometry",Credits=4},
            new course{CourseId=2021,Title="Composition",Credits=3},
            new course{CourseId=2042,Title="Literature",Credits=4}
            };
            foreach (course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new enrollment[]
            {
            new enrollment{StudentId=1,CourseId=1050,Grade=grade.A},
            new enrollment{StudentId=1,CourseId=4022,Grade=grade.C},
            new enrollment{StudentId=1,CourseId=4041,Grade=grade.B},
            new enrollment{StudentId=2,CourseId=1045,Grade=grade.B},
            new enrollment{StudentId=2,CourseId=3141,Grade=grade.F},
            new enrollment{StudentId=2,CourseId=2021,Grade=grade.F},
            new enrollment{StudentId=3,CourseId=1050},
            new enrollment{StudentId=4,CourseId=1050},
            new enrollment{StudentId=4,CourseId=4022,Grade=grade.F},
            new enrollment{StudentId=5,CourseId=4041,Grade=grade.C},
            new enrollment{StudentId=6,CourseId=1045},
            new enrollment{StudentId=7,CourseId=3141,Grade=grade.A},
            };
            foreach (enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}