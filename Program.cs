using System;

namespace LearningCsharpForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(j);
                }
                for (int k = 10; k >= 1; k--)
                {
                    Console.WriteLine(k);
                }
                               
            }
            
        }
    }
}
