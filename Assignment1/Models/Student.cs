using System;
using System.Collections.Generic;

namespace Assignment1.Models
{
    public class Student : Person, IComparable, IComparable<Student>
    {
        public string StudentId { get; set; }
        public string Program { get; set; }
        public DateTime? DateRegistered { get; set; }
        public List<Enrollment> Enrollments { get; set; }

        private const string DEFAULT_STUDENT_ID = "No Student ID Provided";
        private const string DEFAULT_PROGRAM = "No Program Provided";
        private static readonly List<Enrollment> DEFAULT_ENROLLMENTS = new List<Enrollment>();

        public Student() : base()
        {
            StudentId = DEFAULT_STUDENT_ID;
            Program = DEFAULT_PROGRAM;
            DateRegistered = null;
            Enrollments = DEFAULT_ENROLLMENTS;
        }

        public Student(string name,
                       string email,
                       string phoneNumber,
                       Address address,
                       string studentId,
                       string program,
                       DateTime dateRegisted,
                       List<Enrollment> enrollments)
            : base(name, email, phoneNumber, address)
        {
            StudentId = studentId;
            Program = program;
            DateRegistered = dateRegisted;
            Enrollments = enrollments;
        }

        /// <summary>
        /// Checks the passed object for equality, first checking if the passed object is null, or the same object by reference, or a different type, and finally compares StudentIds
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;

            Student studentToCompare = (Student)obj;

            return studentToCompare.StudentId == this.StudentId;
        }

        /// <summary>
        /// Compares for equality using the .Equals() method (which compares StudentIds)
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <returns></returns>
        public static bool operator ==(Student student1, Student student2)
        {
            return Equals(student1, student2);
        }

        /// <summary>
        /// Compares for inequality using the .Equals() method (which compares StudentIds)
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <returns></returns>
        public static bool operator !=(Student student1, Student student2)
        {
            return !Equals(student1, student2);
        }

        /// <summary>
        /// Returns the Student HashCode based on StudentId
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return StudentId.GetHashCode();
        }

        public override string ToString()
        {
            return $"Student:\n" +
                $"\tId: {StudentId}\n" +
                $"\tName: {Name}\n" +
                $"\tAddress: {Address}\n" +
                $"\tPerson Information: \n{base.ToString()}";
        }

        /// <summary>
        /// Compares this student with another object for sorting.
        /// </summary>
        /// <param name="other">The object to compare to.</param>
        /// <returns>
        ///     Exceptions if passed argument is null or not Student object.
        ///     A negative value if this student's ID comes before, 0 if they're equal, and a positive value if it should be placed after.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when "other" is null.</exception>
        /// <exception cref="ArgumentException">Thrown when "other" is not a Student.</exception>
        public int CompareTo(object other)
        {
            if (other == null)
                throw new ArgumentNullException("other");
            if (!(other is Student))
                throw new ArgumentException("Expected Student instance", "other");
            return CompareTo((Student)other);
        }

        /// <summary>
        /// Compares this student with another student based on their IDs for sorting.
        /// </summary>
        /// <param name="other">The student to compare to.</param>
        /// <returns>
        ///     A negative value if this student's ID comes before, 0 if they're equal, and a positive value if it should be placed after.
        /// </returns>
        public int CompareTo(Student other)
        {
            return StudentId.CompareTo(other.StudentId);
        }

        public static bool operator <(Student x, Student y)
        {
            int comparisonResult = x.CompareTo(y);

            if (comparisonResult < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Student x, Student y)
        {
            int comparisonResult = x.CompareTo(y);

            if (comparisonResult <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Student x, Student y)
        {
            int comparisonResult = x.CompareTo(y);

            if (comparisonResult > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >=(Student x, Student y)
        {
            int comparisonResult = x.CompareTo(y);

            if (comparisonResult >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
