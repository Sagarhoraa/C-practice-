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






// Real-Life Example (Call by Value)
// You have Rs. 500 in your pocket (myMoney = 500).

// You tell your friend: "I have Rs. 500!" (You give them a copy of your money info).

// Your friend lies: "No, you have Rs. 100!" (They change their copy to 100).

// But your actual money is still Rs. 500! (Original unchanged).

//  using System;
// class Program
// {
//     // Your friend's function (works on a COPY)
//     static void FriendLies(int friendCopy) 
//     {
//         friendCopy = 100;  // Friend changes their COPY to 100
//         Console.WriteLine($"Friend says: You have Rs. {friendCopy}"); // 100 (LIE!)
//     }

//     static void Main()
//     {
//         int myMoney = 500;  // Your REAL money (Rs. 500)
//         Console.WriteLine($"Truth: You actually have Rs. {myMoney}"); // 500 (TRUE)

//         FriendLies(myMoney); // Friend gets a COPY of your money info

//         // After friend's lie, check your REAL money:
//         Console.WriteLine($"After friend's lie, you STILL have Rs. {myMoney}"); // 500 (UNCHANGED!)
//     }
// }







// //call by reference 
// Real-Life Example
// You hand your actual wallet (ref myMoney) to your friend.

// They change Rs. 500 → Rs. 100 directly in your wallet.

// You check later—your real money is now Rs. 100 😱.


using System;
public class Program
{
    static void friendFuntion(ref int updatedMoney)
    {
        updatedMoney=100;
        Console.WriteLine($"friend say your money is now rs{updatedMoney}");
    }
    static void Main()
    {
        int myMoney=500;
        Console.WriteLine($"my real money is rs:{myMoney}");
        friendFuntion(ref myMoney);
        Console.WriteLine($"oh no my money is now {myMoney} shit , i should not have to give my money to my friend ,");
    }
}
