using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace Regex3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your items list (to finish enter '=>')");
            string str = null;
            string spl = " * ";
            for (; ; )
            {
                Console.Write(spl);
                string s = Console.ReadLine();
                if (s == "=>") break;
                str += spl + s + "\n";
            }

            Regex regex = new Regex(@"^(.*)(\r?\n\1)+$", RegexOptions.Multiline);
            MatchCollection matches = regex.Matches(str);
            string res = regex.Replace(str, "$1\t");


            Console.WriteLine($"{res}");
        }



    }
}

