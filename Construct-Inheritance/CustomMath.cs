using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Construct_Inheritance
{
    public class CustomMath
    {
        public int SumOfOdds(int[] arr)
        {
            int OddSum = 0;
            foreach (int num in arr)
            {
                if(num%2==0)
                {
                    OddSum += num;
                }
                
            }
            return OddSum;
        }
        public string CheckEvenOrOdd(int num)
        {
            if(num%2==0)
            {
                return num + " is an even number";
            }
            else
            {
                return num + " is an odd number";
            }
        }
        public int SumOfEvenNumbersSquared(int[] arr)
        {
            int evenSum = 0;
            foreach (int num in arr)
            {
                if(num%2==0)
                {
                    evenSum += num;
                }
            }
            return evenSum * evenSum;
        }
        public int Factorial(int n)
        {
            int factorialResult = 1;
            for(int i = 1; i <= n; i++)
            {
                factorialResult *= i;

            }
            return factorialResult;
        }
        

           

    }
}
