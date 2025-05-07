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



// using System;

// class ArraySumCalculator
// {
//     public int CalculateSum(int[] numbers) // Reference type (array)
//     {
//         int sum = 0;
//         foreach (int num in numbers)
//         {
//             sum += num;
//         }
//         return sum;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         ArraySumCalculator calculator = new ArraySumCalculator();

//         int[] numbers = { 2, 4, 6, 8, 10 }; // Array (Reference Type)
//         int sum = calculator.CalculateSum(numbers);
        
//         Console.WriteLine("Sum of array elements: " + sum);
//     }
// }

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


//C# program to illustrate call by value and call by reference.
// using System;

// class Example
// {
//     // Call by Value (Changes inside the method do NOT affect the original variable)
//     public void CallByValue(int num)
//     {
//         num += 10; // Modifies local copy
//         Console.WriteLine("Inside CallByValue method: " + num);
//     }

//     // Call by Reference (Changes affect the original variable)
//     public void CallByReference(ref int num)
//     {
//         num += 10; // Modifies the actual variable
//         Console.WriteLine("Inside CallByReference method: " + num);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Example obj = new Example();
        
//         int valueNum = 20;
//         Console.WriteLine("Before CallByValue: " + valueNum);
//         obj.CallByValue(valueNum);
//         Console.WriteLine("After CallByValue: " + valueNum); // No change

//         int refNum = 20;
//         Console.WriteLine("\nBefore CallByReference: " + refNum);
//         obj.CallByReference(ref refNum);
//         Console.WriteLine("After CallByReference: " + refNum); // Changes reflect
//     }
// }
