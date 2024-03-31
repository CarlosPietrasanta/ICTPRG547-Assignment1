using System;

namespace Assignment1.Utils
{
    public static class UtilityClass
    {
        /// <summary>
        /// Performs a linear search in the array to find the index of the target item.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns>The index of the item in the array if found. -1 if not found.</returns>
        public static int LinearSeachArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int i = 0;

            // While we didn't reach the end of the array
            while (i < array.Length)
            {
                // If this evalues to true we know both elements are equal
                if (target.CompareTo(array[i]) == 0)
                {
                    // Return the current index
                    return i;
                }
                else
                {
                    // Add 1 to the index and keep iterating (back to the start of the while loop)
                    i++;
                }
            }

            // If we reach this point the item has not been found, we return -1 to inform so
            return -1;
        }

        /// <summary>
        /// Performs a binary search in the specified SORTED array to find the index of the target element.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns>The index of the item in the array if found. -1 if not found.</returns>
        public static int BinarySearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int min = 0;
            int max = array.Length - 1;
            int mid;

            do
            {
                mid = (max + min) / 2; // Get the middle index of the array

                // Compare items to get a value that will help us determine if it's the same item...
                // ...or if it comes after or before in the array
                int comparisonResult = target.CompareTo(array[mid]); 

                // If comparison returned 0, we know it's the same item, return the current index being evaluated
                if (comparisonResult == 0)
                {
                    return mid;
                }
                // If it returned a positive value, we need to focus on the upper half ("after" the current index) of the array
                else if (comparisonResult > 0)
                {
                    min = mid + 1;
                }
                // Otherwise, it's a negative value, so we need to focus on the lower half ("before" the current index) of the array
                else
                {
                    max = mid - 1;
                }
            } while (min <= max);

            return -1;
        }

        public static void BubbleSort<T>(T[] array) where T : IComparable<T>, IComparable
        {
            T temp;
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }

        public static void BubbleSortDescendingOrder<T>(T[] array) where T : IComparable<T>, IComparable
        {
            T temp;
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) < 0)
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
    }
}
