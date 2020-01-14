using System;
using System.Text.RegularExpressions;

namespace Regex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^((([0-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\.)|(0x[0-9A-Fa-f][0-9A-Fa-f]\.)){3}((([0-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]))|(0x[0-9A-Fa-f][0-9A-Fa-f]))$";
            while (true)
            {
                Console.WriteLine("Enter IP");
                string date = Console.ReadLine();

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
