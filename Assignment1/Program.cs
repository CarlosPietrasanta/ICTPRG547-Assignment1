using Assignment1.Models;
using Assignment1.Utils;
using System;
using System.Collections.Generic;
using static Assignment1.Models.Enrollment;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create some test subjects
            Subject testSubject1 = new Subject("ABC123", "Test Subject ABC123", 99.99M);
            Subject testSubject2 = new Subject("ABC123", "Test Subject ABC123", 99.99M);
            Subject testSubject3 = new Subject("ABC123", "Test Subject ABC123", 99.99M);
            Subject testSubject4 = new Subject("ABC123", "Test Subject ABC123", 99.99M);

            // Create enrollments for student 1
            List<Enrollment> student1Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-30), GradeEnum.NotProvided, SemesterEnum.First, testSubject1),
                new Enrollment(DateTime.Now.AddDays(-60), GradeEnum.NotProvided, SemesterEnum.First, testSubject2),
                new Enrollment(DateTime.Now.AddDays(-15), GradeEnum.NotProvided, SemesterEnum.Second, testSubject3)
            };

            // Create an Address for student 1
            Address student1Address = new Address("123", "Test St.", "Testingham", "5000", StateEnum.SA);

            // Create an Address for student 1
            Student student1 = new Student("Carlos Pietrasanta",
                                   "Carlos.PIETRASANTA@student.tafesa.edu.au",
                                   "04444 444 444",
                                   student1Address,
                                   "123456",
                                   "Test Program",
                                   DateTime.Now.AddYears(-1),
                                   student1Enrollments);

            // Create enrollments for student 2
            List<Enrollment> student2Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-45), GradeEnum.NotProvided, SemesterEnum.Second, testSubject4),
                new Enrollment(DateTime.Now.AddDays(-90), GradeEnum.NotProvided, SemesterEnum.Second, testSubject2),
                new Enrollment(DateTime.Now.AddDays(-20), GradeEnum.NotProvided, SemesterEnum.First, testSubject1)
            };

            // Create an Address for student 2
            Address student2Address = new Address("456", "Example Ave.", "Exampletown", "1000", StateEnum.NSW);

            // Create student 2
            Student student2 = new Student("Emily Johnson",
                                   "emily.johnson@example.com",
                                   "05555 555 555",
                                   student2Address,
                                   "654321",
                                   "Another Test Program",
                                   DateTime.Now.AddYears(-2),
                                   student2Enrollments);

            // Create enrollments for student 3
            List<Enrollment> student3Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-60), GradeEnum.NotProvided, SemesterEnum.First, testSubject3),
                new Enrollment(DateTime.Now.AddDays(-120), GradeEnum.NotProvided, SemesterEnum.Second, testSubject4),
                new Enrollment(DateTime.Now.AddDays(-25), GradeEnum.NotProvided, SemesterEnum.First, testSubject1),
            };

            // Create an Address for student 3
            Address student3Address = new Address("789", "Sample Rd.", "Sampleville", "3000", StateEnum.VIC);

            // Create student 3
            Student student3 = new Student("Michael Smith",
                                   "michael.smith@example.com",
                                   "06666 666 666",
                                   student3Address,
                                   "123456", // Note that for testing purposes this student has the same Id as student1
                                   "Yet Another Program",
                                   DateTime.Now.AddYears(-3),
                                   student3Enrollments);

            //Console.WriteLine(student1);
            //Console.WriteLine(student2);
            //Console.WriteLine(student3);

            //Console.WriteLine();

            //Console.WriteLine($"Compare student1 and student2 using .Equals() (expected False): {student1.Equals(student2)}");
            //Console.WriteLine($"Compare student1 and student2 using \"==\" (expected False): {student1 == student2}");
            //Console.WriteLine($"Compare student1 and student2 using \"!=\" (expected True): {student1 != student2}");

            //Console.WriteLine();

            //Console.WriteLine($"Compare student1 and student3 using .Equals() (expected True): {student1.Equals(student3)}");
            //Console.WriteLine($"Compare student1 and student3 using \"==\" (expected True): {student1 == student3}");
            //Console.WriteLine($"Compare student1 and student3 using \"!=\" (expected False): {student1 != student3}");

            //Console.WriteLine();

            //Console.WriteLine($"Compare student1 with null (expected False): {student1.Equals(null)}");
            //Console.WriteLine($"Compare student1 with student 1 (expected True): {student1.Equals(student1)}");
            //Console.WriteLine($"Compare student1 with an Address (expected False): {student1.Equals(student3Address)}");

            //Console.WriteLine();

            //Console.WriteLine($"Student 1 HashCode: {student1.GetHashCode()}");
            //Console.WriteLine($"Student 2 HashCode: {student2.GetHashCode()}");
            //Console.WriteLine($"Student 3 HashCode: {student3.GetHashCode()}");

            //Console.WriteLine();

            Console.WriteLine($"Student 1 (Id = {student1.StudentId}) .CompareTo() Student 2 (Id = {student2.StudentId}): {student1.CompareTo(student2)}");
            Console.WriteLine($"Student 1 (Id = {student1.StudentId}) .CompareTo() Student 3 (Id = {student3.StudentId}): {student1.CompareTo(student3)}");
            Console.WriteLine($"Student 2 (Id = {student2.StudentId}) .CompareTo() Student 3 (Id = {student3.StudentId}): {student2.CompareTo(student3)}");
            
            Console.WriteLine();

            Console.WriteLine($"Student 1 (Id = {student1.StudentId}) < Student 2 (Id = {student2.StudentId}): {student1 < student2}");
            Console.WriteLine($"Student 1 (Id = {student1.StudentId}) <= Student 2 (Id = {student2.StudentId}): {student1 <= student2}");
            Console.WriteLine($"Student 1 (Id = {student1.StudentId}) > Student 2 (Id = {student2.StudentId}): {student1 > student2}");
            Console.WriteLine($"Student 1 (Id = {student1.StudentId}) >= Student 2 (Id = {student2.StudentId}): {student1 >= student2}");

            Console.WriteLine();

            Console.WriteLine($"Student 1 (Id = {student1.StudentId}) < Student 3 (Id = {student3.StudentId}): {student1 < student3}");
            Console.WriteLine($"Student 1 (Id = {student1.StudentId}) <= Student 3 (Id = {student3.StudentId}): {student1 <= student3}");
            Console.WriteLine($"Student 1 (Id = {student1.StudentId}) > Student 3 (Id = {student3.StudentId}): {student1 > student3}");
            Console.WriteLine($"Student 1 (Id = {student1.StudentId}) >= Student 3 (Id = {student3.StudentId}): {student1 >= student3}");

            Console.WriteLine();

            Console.WriteLine($"Student 2 (Id = {student2.StudentId}) < Student 3 (Id = {student3.StudentId}): {student2 < student3}");
            Console.WriteLine($"Student 2 (Id = {student2.StudentId}) <= Student 3 (Id = {student3.StudentId}): {student2 <= student3}");
            Console.WriteLine($"Student 2 (Id = {student2.StudentId}) > Student 3 (Id = {student3.StudentId}): {student2 > student3}");
            Console.WriteLine($"Student 2 (Id = {student2.StudentId}) >= Student 3 (Id = {student3.StudentId}): {student2 >= student3}");

            Console.WriteLine();

            Student[] studentArray = TestData.CreateTestStudentArray();

            Console.WriteLine("Original Array Order:");

            foreach (var item in studentArray)
            {
                Console.WriteLine("\t" + item.StudentId);
            }

            int student1IndexLinearSearch = UtilityClass.LinearSeachArray(studentArray, student1);

            Console.WriteLine($"\nIndex of Student 1 Linear Search (Id {student1.StudentId}): {student1IndexLinearSearch}\n");

            UtilityClass.BubbleSort(studentArray);

            Console.WriteLine("Sorted Array Order:");

            foreach (var item in studentArray)
            {
                Console.WriteLine("\t" + item.StudentId);
            }

            Console.WriteLine("\nNow we can use the binary search:");

            int student1IndexBinarySearch = UtilityClass.BinarySearchArray(studentArray, student1);

            Console.WriteLine($"\nIndex of Student 1 Binary Search (Id {student1.StudentId}): {student1IndexBinarySearch}\n");

            Console.WriteLine("Now let's test Bubble Sort in descending order:");

            UtilityClass.BubbleSortDescendingOrder(studentArray);

            Console.WriteLine("Sorted Array Descending Order:");

            foreach (var item in studentArray)
            {
                Console.WriteLine("\t" + item.StudentId);
            }

            Console.ReadLine();
        }
    }
}
