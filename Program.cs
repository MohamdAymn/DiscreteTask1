using System;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n1 = ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("n2 = ");
            int n2 = int.Parse(Console.ReadLine());
            int Prime = 0;
            for (int i = n1; i <= n2; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    if (i % x == 0)
                    {
                        Prime += 1;
                    }
                }
                if (Prime == 2)
                {
                    Console.Write(i + "\t");
                    Prime = 0;
                }
                else
                {
                    Prime = 0;
                }
            }
        }
    }
}
