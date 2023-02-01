//Read and Print elements of an array



using System;

public class exercise1
{
    public static void Main()

    {
        int[] arr = new int[10];
        Console.WriteLine("Read and print elements of an array");
        Console.WriteLine("-----------------------------------");

        Console.WriteLine("Write the elements: ");
        for(int i = 0; i < 10; i++)
        {
            Console.Write("The {0} element is - ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("The elements of the array are: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(arr[i]);
        }
    }
    

}

