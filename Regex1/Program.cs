using System;
using System.Text.RegularExpressions;

namespace Regex1
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"^(1[0-9][0-9][0-9]|200[0-9]|201[0-2])[-\/.](0[1-9]|1[0-2])[-\/.]([0|1|2][0-9]|30) (0[0-9]|1[0-2]):([1-5][1-9])$";
            while (true)
            {
                Console.WriteLine("Enter Date&Time");
                string date = Console.ReadLine();
                // date = date.Remove(date.Length - 1, 1);

                if (Regex.IsMatch(date, pattern))
                {
                    Console.WriteLine("yes");
                    break;
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
