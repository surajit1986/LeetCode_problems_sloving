using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    internal  class FizzBuzz
    {
        public void PrintFizzBuzz(int arr)
        {
            if(arr < 1) { return; }
            else
            {
                for(int item =1; item< arr; item++)
                {
                    if((item%3 == 0) && (item % 5 == 0)) { Console.WriteLine("Fizz Buzz" ); }
                    else if((item%3 == 0)) { Console.WriteLine("Fizz"); }
                    else if(item%5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(item);
                    }
                    
                }
            }
        }
    }
}
