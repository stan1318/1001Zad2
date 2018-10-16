using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {Console.WriteLine("How many numbers do you want in the array?:");
            int n=Convert.ToInt32(Console.ReadLine());
            int [] nummas=new int[n];
            Console.WriteLine("Type in the numbers you want(0-5000),each on a new line:");
            
            for (int i = 0; i < n; i++)
            {
                nummas[i] = Convert.ToInt32(Console.ReadLine());
               
                
                while(nummas[i] > 5000 || nummas[i] < 0)
                    {Console.WriteLine("Wrong Input!");
                      nummas[i] = Convert.ToInt32(Console.ReadLine());
                    }
            }
            Array.Reverse(nummas);
            for (int i = 0; i<n; i++)
            {
                Console.WriteLine(nummas[i]);
            }
                Console.ReadLine();
        }
    }
}
//Reverse an array of numbers
