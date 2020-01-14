using System;

namespace Algorithm1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN = 110;
            int N;
            do
            {
                Console.WriteLine("Enter N (between 0 and 109)");
                N = Convert.ToInt32(Console.ReadLine());
            }

            while (0 >= N || N > MIN);

            string str = "";

            bool isSimple = false;
            for (; ; )
            {
                if (isSimple)
                {
                    Console.WriteLine("-1");
                    break;
                }
                if (N == 1)
                {
                    var result = str.ToCharArray();
                    Array.Sort(result);

                    Console.WriteLine(new string(result));
                    Console.ReadKey();
                    break;
                }
                for (var i = 9; i >= 1; i--)
                {
                    if (i == 1)
                    {
                        isSimple = true;
                    }
                    if (N % i == 0)
                    {
                        str += i;
                        N = N / i;
                        break;
                    }
                }
            }
        }
    }
}