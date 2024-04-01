using Assignment1.Models;
using Assignment1.Utils;
using System;
using static Assignment1.Models.Enrollment;

namespace TestProject
{
    public class SortingTests
    {
        Student[] studentArray;

       [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestSortAscending()
        {
            studentArray = TestData.CreateTestStudentArray();

            UtilityClass.BubbleSort(studentArray);

            Assert.IsTrue(IsSortedAscending(studentArray));
        }

        [Test]
        public void TestSortDescending()
        {
            studentArray = TestData.CreateTestStudentArray();

            UtilityClass.BubbleSortDescendingOrder(studentArray);

            Assert.IsTrue(IsSortedDescending(studentArray));
        }

        private bool IsSortedAscending(Student[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].StudentId.CompareTo(array[i + 1].StudentId) > 0)
                {
                    return false;
                }
                    
            }
            return true;
        }

        private bool IsSortedDescending(Student[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].StudentId.CompareTo(array[i + 1].StudentId) < 0)
                {
                    return false;
                }
                    
            }
            return true;
        }
    }
}