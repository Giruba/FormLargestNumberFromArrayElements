using System;

namespace FormLargestNumberFromArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Form Largest number from elements in the array!");
            Console.WriteLine("-----------------------------------------------");

            string[] array = ArrayUtility.GetArrayFromInput();
            Console.WriteLine("The largest number formed is "+
                ArrayUtility.GetLargestNumberFormedFromArray(array));

            Console.ReadLine();
        }
    }
}
