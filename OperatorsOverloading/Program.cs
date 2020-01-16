using System;

namespace OperatorsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter time for clock number 1:\nEnter hours: ");
            int Hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter minuts: ");
            int Min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter seconds: ");
            int Sec = Convert.ToInt32(Console.ReadLine());

            Clock clockNum1 = new Clock(Hour, Min, Sec);

            Console.Write("Enter time for clock number 2:\nEnter hours: ");
            int Hour2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter minuts: "); 
            int Min2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter seconds: "); 
            int Sec2 = Convert.ToInt32(Console.ReadLine());

            Clock clockNum2 = new Clock(Hour2, Min2, Sec2);

            if (clockNum1 > clockNum2) Console.WriteLine("clock number 1 > clock number 2");
            else Console.WriteLine("clock number 1 <= clock number 2");

            Console.Write("Enter time for timer:\nEnter minuts: ");
            int Min3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter seconds: "); 
            int Sec3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter milliseconds: "); 
            int Millsec = Convert.ToInt32(Console.ReadLine());

            Timer timer = new Timer(Min3, Sec3, Millsec);
            Clock newClock = clockNum1 + timer;
           Console.WriteLine($"clock number 1 + timer = {newClock.Hour}:{newClock.Minute}:{newClock.Second}");


        }

    }
}
