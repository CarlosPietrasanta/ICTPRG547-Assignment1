using Assignment1.Models;
using Assignment1.Utils;
using static Assignment1.Models.Enrollment;

namespace TestProject
{
    public class LinearSearchTests
    {
        Student[] studentArray;
        Student existingStudent;
        Student nonExistingStudent;

       [SetUp]
        public void Setup()
        {
            studentArray = TestData.CreateTestStudentArray();

            // Create some test subjects
            Subject testSubject1 = new Subject("ABC123", "Test Subject ABC123", 99.99M);
            Subject testSubject2 = new Subject("ABC123", "Test Subject ABC123", 99.99M);
            Subject testSubject3 = new Subject("ABC123", "Test Subject ABC123", 99.99M);

            // Create enrollments for test student 1
            List<Enrollment> student1Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-30), GradeEnum.NotProvided, SemesterEnum.First, testSubject1),
                new Enrollment(DateTime.Now.AddDays(-60), GradeEnum.NotProvided, SemesterEnum.First, testSubject2),
                new Enrollment(DateTime.Now.AddDays(-15), GradeEnum.NotProvided, SemesterEnum.Second, testSubject3)
            };

            // Create an Address for test student 1
            Address student1Address = new Address("123", "Test St.", "Testingham", "5000", StateEnum.SA);

            // Create an Address for test student 1
            existingStudent = new Student("Carlos Pietrasanta",
                                   "Carlos.PIETRASANTA@student.tafesa.edu.au",
                                   "04444 444 444",
                                   student1Address,
                                   "123456",
                                   "Test Program",
                                   DateTime.Now.AddYears(-1),
                                   student1Enrollments);


            // Create enrollments for test student 2
            List<Enrollment> student2Enrollments = new List<Enrollment>()
            {
                new Enrollment(DateTime.Now.AddDays(-90), GradeEnum.NotProvided, SemesterEnum.Second, testSubject2),
                new Enrollment(DateTime.Now.AddDays(-120), GradeEnum.NotProvided, SemesterEnum.Second, testSubject3),
                new Enrollment(DateTime.Now.AddDays(-180), GradeEnum.NotProvided, SemesterEnum.First, testSubject1)
            };

            // Create an Address for test student 2
            Address student2Address = new Address("123", "Fake St.", "Nonexistingburgh", "1234", StateEnum.NSW);

            // Create an Address for test student 2
            nonExistingStudent = new Student("Not-An-Actual Student",
                                   "NotAnActual@student.nope.edu.au",
                                   "0111 111 111",
                                   student2Address,
                                   "000000",
                                   "Unknown Program",
                                   DateTime.Now.AddYears(-15),
                                   student2Enrollments);
        }

        [Test]
        public void TestStudentFound()
        {
            int existingStudentIndexLinearSearch = UtilityClass.LinearSeachArray(studentArray, existingStudent);

            Assert.That(existingStudentIndexLinearSearch > -1);
        }

        [Test]
        public void TestStudentNotFound()
        {
            int nonExistingStudentIndexLinearSearch = UtilityClass.LinearSeachArray(studentArray, nonExistingStudent);

            Assert.That(nonExistingStudentIndexLinearSearch == -1);
        }
    }
}