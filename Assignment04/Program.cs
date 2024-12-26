using System;
using System.IO;
using System.Reflection;
using System.Threading.Channels;

namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1_Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            /*
            1- Passing by Value (Value Type Parameters):

          _When a parameter is passed by value, a copy of the variable is passed to the method.
          _Any changes made to the parameter inside the method do not affect the original variable.
         
             
           2- Passing by Reference (Reference Type Parameters):          
          _When a parameter is passed by reference, the method receives a reference to the actual variable.
          _Changes made to the parameter inside the method directly affect the original variable.

             */

            //static void PassByValue(int number)
            //{

            //    number += 10;
            //    Console.WriteLine("Inside PassByValue: " + number);
            //}

            //// Method with pass by reference
            //static void PassByReference(ref int number)
            //{
            //    number += 10;
            //    Console.WriteLine("Inside PassByReference: " + number);
            //}



            //int value = 5;

            //// Passing by value
            //Console.WriteLine("Before PassByValue: " + value);
            //PassByValue(value);
            //Console.WriteLine("After PassByValue: " + value);

            //// Passing by reference
            //Console.WriteLine("Before PassByReference: " + value);
            //PassByReference(ref value);
            //Console.WriteLine("After PassByReference: " + value);


            #endregion

            #region 2_Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            /*
              1_Passing by Value (Reference Type):
               _A copy of the reference to the object is passed to the method.
               _Modifications to the object's properties will affect the original object since the reference points to the same object.
               _However, if the reference is reassigned to a new object within the method, the original reference outside the method remains unaffected.

              2_Passing by Reference (Reference Type):
              _The actual reference to the object is passed to the method.
              _Any modifications to the object's properties or reassignment of the reference will directly affect the original reference outside the method.

              */

            //class Person
            //{
            //    public string Name { get; set; }


            //// Passing by value
            //static void PassByValue(Person person)
            //{
            //    person.Name = "Updated Name (By Value)"; // Modifies the property
            //    person = new Person { Name = "New Object (By Value)" }; // Reassigns the reference
            //}

            //// Passing by reference
            //static void PassByReference(ref Person person)
            //{
            //    person.Name = "Updated Name (By Reference)"; // Modifies the property
            //    person = new Person { Name = "New Object (By Reference)" }; // Reassigns the reference
            //}

            //static void Main()
            //{
            //    Person person = new Person { Name = "Original Name" };

            //    // Passing by value
            //    Console.WriteLine("Before PassByValue: " + person.Name);
            //    PassByValue(person);
            //    Console.WriteLine("After PassByValue: " + person.Name);

            //    // Passing by reference
            //    Console.WriteLine("Before PassByReference: " + person.Name);
            //    PassByReference(ref person);
            //    Console.WriteLine("After PassByReference: " + person.Name);
            //}

            #endregion

            #region 3_Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //static double Calculate(double num1, double num2, string operation)
            //{
            //    if (operation == "sum")
            //    {
            //        return num1 + num2;  
            //    }
            //    else if (operation == "subtract")
            //    {
            //        return num1 - num2;    
            //    }
            //    else
            //    {
            //        throw new ArgumentException("Invalid operation. Use 'sum' or 'subtract'.");
            //    }
            //}

            //Console.Write("Enter the first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the operation (sum or subtract): ");
            //string operation = Console.ReadLine().ToLower();


            //try
            //{
            //    double result = Calculate(num1, num2, operation);
            //    Console.WriteLine($"The result of the {operation} operation is: {result}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            #endregion

            #region 4_Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.,Output should be li,Enter a numb,The sum of the digits of the number 25 is: 7
            //static int SumOfDigits(int number)
            //{
            //    int sum = 0;
            //    while (number > 0)
            //    {
            //        int digit = number % 10; // الحصول على الرقم الأخير
            //        sum += digit; // إضافة الرقم إلى المجموع
            //        number /= 10; // إزالة الرقم الأخير
            //    }
            //    return sum;
            //}



            //    Console.Write("Enter a number: ");
            //    int number = Convert.ToInt32(Console.ReadLine()); // قراءة الرقم من المستخدم

            //    int result = SumOfDigits(number); // حساب مجموع الأرقام
            //    Console.WriteLine($"The sum of the digits of the number {number} is: {result}");


            #endregion

            #region 5_Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //static bool IsPrime(int number)
            //{

            //    if (number < 2)
            //        return false;


            //    for (int i = 2; i <= Math.Sqrt(number); i++)
            //    {
            //        if (number % i == 0)
            //            return false; 
            //    }

            //    return true;  
            //}



            //    Console.Write("Enter a number: ");
            //    int number = Convert.ToInt32(Console.ReadLine());  


            //    if (IsPrime(number))
            //        Console.WriteLine($"{number} is a prime number.");  
            //    else
            //        Console.WriteLine($"{number} is not a prime number.");  


            #endregion

            #region 6_Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //static void MinMaxArray(int[] array, ref int minValue, ref int maxValue)
            //{
            //     minValue = array[0];
            //    maxValue = array[0];


            //    for (int i = 1; i < array.Length; i++)
            //    {
            //        if (array[i] < minValue)
            //            minValue = array[i];  

            //        if (array[i] > maxValue)
            //            maxValue = array[i];  
            //    }
            //}



            //    int[] numbers = { 99, 23, 66, 33, 9, 55 };


            //    int min = 0, max = 0;


            //    MinMaxArray(numbers, ref min, ref max);


            //    Console.WriteLine($"The minimum value is: {min}");
            //    Console.WriteLine($"The maximum value is: {max}");

            #endregion

            #region 7_Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //static long Factorial(int number)
            //{

            //    if (number == 0 || number == 1)
            //        return 1;

            //    long result = 1;


            //    for (int i = 2; i <= number; i++)
            //    {
            //        result *= i;
            //    }

            //    return result;
            //}


            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //long result = Factorial(number);
            //Console.WriteLine($"The factorial of {number} is: {result}");


            #endregion

            #region 8_Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            static string ChangeChar(string str, int position, char newChar)
            {
                 
                if (position < 0 || position >= str.Length)
                {
                    return "Invalid position";
                }

                 
                char[] charArray = str.ToCharArray();

                 
                charArray[position] = newChar;

                 
                return new string(charArray);
            }

             
                 
                Console.Write("Enter a string: ");
                string inputString = Console.ReadLine();

                 
                Console.Write("Enter the position (0-based index): ");
                int position = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the new character: ");
                char newChar = Convert.ToChar(Console.ReadLine());

                   
                string result = ChangeChar(inputString, position, newChar);

                 
                Console.WriteLine("Modified string: " + result);
             


            #endregion
        }
    }
}
    
 
       
