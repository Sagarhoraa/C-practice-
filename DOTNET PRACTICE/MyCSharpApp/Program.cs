//C# program to calculate factorial of a number using value type.
// using System;

// class FactorialCalculator
// {
//     public int CalculateFactorial(int number)
//     {
//         if (number <= 0) return 1;
//         return number * CalculateFactorial(number - 1);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         FactorialCalculator calculator = new FactorialCalculator();
//         Console.Write("Enter a number: ");
//         int number = int.Parse(Console.ReadLine());
//         int factorial = calculator.CalculateFactorial(number);
//         Console.WriteLine($"Factorial of {number} is {factorial}");
//     }
// }
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


//- Write a C# program to calculate sum of array using reference type.



using System;

class ArraySumCalculator
{
    public int CalculateSum(int[] numbers) // Reference type (array)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}

class Program
{
    static void Main()
    {
        ArraySumCalculator calculator = new ArraySumCalculator();

        int[] numbers = { 2, 4, 6, 8, 10 }; // Array (Reference Type)
        int sum = calculator.CalculateSum(numbers);
        
        Console.WriteLine("Sum of array elements: " + sum);
    }
}
