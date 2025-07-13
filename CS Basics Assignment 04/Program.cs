using System.ComponentModel;

namespace CS_Basics_Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            /// Example 
            /// Input: 5
            /// Output: 1, 2, 3, 4, 5
            /// 

            //Console.Write("Please enter a Number: ");
            //int.TryParse(Console.ReadLine(), out int Num01);

            //for (int i = 1; i <= Num01 ; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            /// Example
            /// Input: 5
            /// Outputs: 5 10 15 20 25 30 35 40 45 50 55 60
            /// 

            //Console.Write("Please enter a Number: ");
            //int.TryParse(Console.ReadLine(), out int Num01);

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(Num01 * i);
            //}

            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            /// Example:
            /// Input: 15
            /// Output: 2 4 6 8 10 12 14
            /// 

            //Console.Write("Please enter a Number: ");
            //int.TryParse(Console.ReadLine(), out int Num01);

            //for (int i = 2; i <= Num01; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region 4- Write a program that takes two integers then prints the power.
            /// Example:
            /// Input: 4 3
            /// Output: 64
            /// Hint: how to calculate 4^3 = 4 * 4 * 4 =64
            /// 

            //Console.Write("Please enter first Number: ");
            //int.TryParse(Console.ReadLine(), out int Num01);

            //Console.Write("Please enter second Number: ");
            //int.TryParse(Console.ReadLine(), out int Num02);

            //int Result = 1;

            //for (int i = 0; i < Num02; i++)
            //{
            //    Result *= Num01;
            //}

            //Console.WriteLine(Result);
            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.
            /// Example
            /// Input: - Enter Marks of five subjects: 95 76 58 90 89
            /// Output: Total marks = 408
            /// Average Marks = 81
            /// Percentage = 81
            /// 

            //int Total = 1;
            //Console.WriteLine("Enter Marks for 5 Subjects:- ");

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write($"Number {i}: ");
            //    int.TryParse(Console.ReadLine(), out int mark);
            //    Total += mark;
            //}

            //double Avg = Total / 5.00;
            //double Percentage = (Total / 500.00) * 100;

            //Console.Clear();
            //Console.WriteLine($"Total Marks = {Total}");
            //Console.WriteLine($"Average Marks = {Avg}");
            //Console.WriteLine($"Percentage Marks = {Percentage} %");

            #endregion

            #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write("Please enter a string: ");
            //string input = Console.ReadLine();

            //Console.Write("Reversed string: ");

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(input[i]);
            //}

            //Console.WriteLine();

            #endregion

            #region 7- Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.Write("Please Enter an Integer: ");
            //string input = Console.ReadLine();

            //if (input.StartsWith("-")) {
            //    input = input.Substring(1);
            //    Console.WriteLine("-");
            //}

            //Console.Write("Reversed Number: ");

            //for (int i = input.Length - 1; i >= 0 ; i--)
            //{
            //    Console.Write(input[i]);
            //}

            #endregion

            #region 8- Write a program in C# Sharp to find prime numbers within a range of numbers.
            /// Test Data :
            /// Input starting number of ranges: 1
            /// Input ending number of range : 50
            /// 
            //Console.Write("Enter the start number: ");
            //int.TryParse(Console.ReadLine(), out int start);

            //Console.Write("Enter the end number: ");
            //int.TryParse(Console.ReadLine(), out int end);

            //Console.WriteLine($"\nPrime numbers between {start} and {end} are:");

            //for (int i = start; i <= end; i++)
            //{
            //    if (i < 2)
            //        continue; 

            //    bool isPrime = true;

            //    for (int y = 2; y <= i / 2; y++)
            //    {
            //        if (i % y == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            //Console.WriteLine(); 

            #endregion

            #region 9- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            /// Test Data :
            /// Enter a number to convert :25
            /// Expected Output :
            /// The Binary of 25 is 11001.
            /// 
            //Console.Write("Enter a decimal number: ");
            //int.TryParse(Console.ReadLine(), out int number);

            //if (number == 0)
            //{
            //    Console.WriteLine("Binary: 0");
            //}
            //else
            //{
            //    string binary = "";

            //    for (int i = number; i > 0; i /= 2)
            //    {
            //        int remainder = i % 2;
            //        binary = remainder + binary; 
            //    }

            //    Console.WriteLine($"The Binary of {number} is {binary}");
            //}


            #endregion

            #region 10- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            Console.WriteLine("Enter coordinates for point 1:");
            Console.Write("x1: ");
            int.TryParse(Console.ReadLine(), out int x1);
            Console.Write("y1: ");
            int.TryParse(Console.ReadLine(), out int y1);

            Console.WriteLine("Enter coordinates for point 2:");
            Console.Write("x2: ");
            int.TryParse(Console.ReadLine(), out int x2);
            Console.Write("y2: ");
            int.TryParse(Console.ReadLine(), out int y2);

            Console.WriteLine("Enter coordinates for point 3:");
            Console.Write("x3: ");
            int.TryParse(Console.ReadLine(), out int x3);
            Console.Write("y3: ");
            int.TryParse(Console.ReadLine(), out int y3);

            int leftSide = (y2 - y1) * (x3 - x2);
            int rightSide = (y3 - y2) * (x2 - x1);

            if (leftSide == rightSide)
            {
                Console.WriteLine("The points lie on a straight line.");
            }
            else
            {
                Console.WriteLine("The points do NOT lie on a straight line.");
            }


            #endregion
        }
    }
}
