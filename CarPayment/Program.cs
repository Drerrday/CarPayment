using System;

namespace CarPayment
{
    class Program
    {
        static void Main(string[] args)
        {
            float T, D, I, M, P;
            Console.WriteLine("How much would you like to finance?");
            T = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("How much will you be putting down?");
            D = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("What is the interest?");
            I = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("How many years will you be financing for?");
            M = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(T + D + I + M);
            
            I = (I / 12) / 100;
            M = M * 12;
            Console.WriteLine(3 ^ 2);
            P = I * (T - D) * (((1 + I) ^ M) / (((1 + I) ^ M) - 1));

            Console.WriteLine(P);
        }
    }
}
