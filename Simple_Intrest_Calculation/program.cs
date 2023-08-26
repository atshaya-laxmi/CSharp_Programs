using System;

namespace SimpleInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            float p,t,r;
            float product, si=0;
            Console.WriteLine("Enter principal amount, time and rate of interest to calculate simple interest\n");
            Console.Write("Principal amount:\t");
            p = float.Parse(Console.ReadLine());
            Console.Write("Time:\t");
            t = float.Parse(Console.ReadLine());
            Console.Write("Rate of Interest:\t");
            r = float.Parse(Console.ReadLine());

            product = p * t* r;
            si = product/100;
            Console.WriteLine("Simple Interest:\t{0}", si);
        }
    }
}