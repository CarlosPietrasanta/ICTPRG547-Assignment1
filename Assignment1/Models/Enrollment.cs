using System;

namespace Assignment1.Models
{
    public class Enrollment
    {
        public DateTime? DateEnrolled { get; set; }
        public GradeEnum Grade { get; set; }
        public SemesterEnum Semester { get; set; }
        public Subject Subject { get; set; }    

        public Enrollment(DateTime dateEnrolled, GradeEnum grade, SemesterEnum semester, Subject subject)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            Subject = subject;
        }

        public enum SemesterEnum
        {
            NotProvided,
            First,
            Second
        }

        public enum GradeEnum
        {
            NotProvided,
            Fail,
            Pass
        }
    }
}
