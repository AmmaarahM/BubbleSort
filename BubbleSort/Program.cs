using System;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 20, 90, 50, 100, 5, 9 };
            int temp; // holds the value being "swapped"
            for(int x =0 ; x < numbers.Length-1 ; x++) 
            {
                for(int y =0 ; y < numbers.Length-1-x ;y++) 
                {
                    if (numbers[y] > numbers[y+1])
                    {
                        temp = numbers[y];
                        numbers[y] = numbers[y+1];
                        numbers[y+1] = temp;
                    }
                }
            }
            foreach(int x in numbers) // outputs the sorted array
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
