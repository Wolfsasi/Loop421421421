using System;

namespace MathProof
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 2;
            while (op == 2) { 
            Console.WriteLine("Insert a number: ");
            int num = int.Parse(Console.ReadLine());
            while (num != 1) { 
            if ((num % 2) == 0)
            {
                num = num / 2;
            }
            else
            {
                num = (num * 3)+1;
                        
            }
                Console.WriteLine(num);
                    
            }
                Console.WriteLine("Repeat? :\n1)No \n2)Yes");
                op = int.Parse(Console.ReadLine());
            }
        }
    }
}
