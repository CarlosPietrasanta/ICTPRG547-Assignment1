using System;

namespace Assignment1.Models
{
    public class Enrollment
    {
        public DateTime? DateEnrolled { get; set; }
        public GradeEnum Grade { get; set; }
        public SemesterEnum Semester { get; set; }
        public Subject Subject { get; set; }    
        
        private const SemesterEnum DEFAULT_SEMESTER = SemesterEnum.NotProvided;
        private const GradeEnum DEFAULT_GRADE = GradeEnum.NotProvided;
        private static readonly Subject DEFAULT_SUBJECT = new Subject();

        public Enrollment()
        {
            DateEnrolled = null;
            Grade = DEFAULT_GRADE;
            Semester = DEFAULT_SEMESTER;
            Subject = DEFAULT_SUBJECT;
        }

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
        public override string ToString()
        {
            return $"Enrolled on: {DateEnrolled}, Grade: {Grade}, Semester: {Semester}, Subject: {Subject}";
        }
    }
}
