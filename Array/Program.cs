using System;
public class SamplesArray
{

    public static void Main()
    {

        // Creates and initializes a new integer array and a new Object array.
        int[] arrayTenInts = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Object[] elevenObjectArray = new Object[11] { 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };

        // Prints the initial values of both arrays.
        Console.WriteLine("Starting Array:\n");
        Console.Write("Integer array:");
        PrintTheseIntValues(arrayTenInts);
        Console.Write("Object array: ");
        PrintTheseObjectValues(elevenObjectArray);

        // Copies the first thrree elements from the integer array to the Object array.
        System.Array.Copy(arrayTenInts, elevenObjectArray, 3);

        // Prints the values of the modified arrays.
        Console.WriteLine("\nAfter copying the first three elements of the integer array to the Object array:");
        Console.Write("integer array:");
        PrintTheseIntValues(arrayTenInts);
        Console.Write("Object array: ");
        PrintTheseObjectValues(elevenObjectArray);

        // Copies the last element from the Object array to the integer array.
        System.Array.Copy(elevenObjectArray, elevenObjectArray.GetUpperBound(0) - 0, arrayTenInts, arrayTenInts.GetUpperBound(0) - 0, 1);

        // Prints the values of the modified arrays.
        Console.WriteLine("\nAfter copying the last element of the Object array to the integer array:");
        Console.Write("integer array:");
        PrintTheseIntValues(arrayTenInts);
        Console.Write("Object array: ");
        PrintTheseObjectValues(elevenObjectArray);
        Console.WriteLine("The End of Main");
        Console.ReadLine();
    }
    //two different methods to print arrays
    public static void PrintTheseObjectValues(Object[] stringArray)
    {
        foreach (Object thisObject in stringArray)
        {
            Console.Write("\t{0}", thisObject);
        }
        Console.WriteLine("\n^^^Method Prints Object values \n");
    }

    public static void PrintTheseIntValues(int[] objectArray)
    {
        foreach (int thisString in objectArray)
        {
            Console.Write("\t{0}", thisString);
        }
        Console.WriteLine("\n^^^Method Prints string values \n");
    }
}
