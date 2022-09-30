using System;

namespace SquareEveryDigit
{
    
   
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Digit: ");
            int digit  = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Each digit squared is: " + SquareDigit(digit));
        }


        public static int SquareDigit(int n)
        {
            String digits = n.ToString();
            String result = "";
            foreach (char c in digits)
            {
                double squared = Math.Pow(Int32.Parse(c.ToString()), 2);
                result += squared.ToString();
            }
            return Int32.Parse(result);
        }
    }
}
