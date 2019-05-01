using System;
using System.Collections.Generic;
using System.Text;

namespace FormLargestNumberFromArrayElements
{
    public static class ArrayUtility
    {
        public static void PrintArray(string[] array) {
            Console.WriteLine();
            Console.WriteLine("Printing the array ------->");
            int length = array.Length;

            for (int arrayIndex = 0; arrayIndex < length; arrayIndex ++) {
                Console.Write(array[arrayIndex]+" ");
            }

            Console.WriteLine();
        }

        public static String GetLargestNumberFormedFromArray(string[] array)
        {
            String result = null;
            ArrayUtility.PrintArray(array);
            var comparer = new StringConcatenatorComparer();
            Array.Sort(array, comparer);
            for (int arrayIndex = 0; arrayIndex < array.Length; arrayIndex++)
            {
                result += array[arrayIndex];
            }
            ArrayUtility.PrintArray(array);
            return result;
        }

        public static string[] GetArrayFromInput()
        {
            string[] array = null;
            Console.WriteLine("Enter the number of elements in the array");
            try
            {
                int numberOfElements = int.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Enter the elements separated by " +
                    "space, comma or semi-colon");
                array = new string[numberOfElements];
                String[] elements = Console.ReadLine().Trim().Split(' ', ',', ';');
                for (int index = 0; index < numberOfElements; index++)
                {
                    array[index] = elements[index];
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Thrown exception is " + exception.Message);
            }
            return array;
        }
    }
}
