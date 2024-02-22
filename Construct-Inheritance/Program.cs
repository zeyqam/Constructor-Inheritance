
using Construct_Inheritance;

CustomMath mathOperations=new CustomMath();
int[] arr1 = { 1, 2, 3, 4, 5 };
Console.WriteLine("Sum of odd numbers:" + mathOperations.SumOfOdds(arr1));

int num = 7;
Console.WriteLine("Number is:" +mathOperations.CheckEvenOrOdd(num));

int[] arr2 = {1,2,3,4,5};
Console.WriteLine("Sum of squared numbers:" + mathOperations.SumOfEvenNumbersSquared(arr2));

int n= 5;
Console.WriteLine("Factorial of "  + n + "is" +mathOperations.Factorial(n));