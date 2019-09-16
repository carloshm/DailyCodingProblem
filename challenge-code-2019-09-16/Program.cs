using System;

namespace challenge_code_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("start -- challenge code 001");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Given a list of numbers and a number k, return whether any two numbers from the list add up to k.");
            Console.WriteLine("For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.");

            int[] data = new int[4] {10, 15, 3, 7};
            int sum = 17;

            Console.ForegroundColor = ConsoleColor.White;
            foreach (int val in data){
                if(Array.Exists(data, number => number == (sum - val))){
                    Console.WriteLine(val);
                }                
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("end -- challenge code 001");
        }
    }
}
