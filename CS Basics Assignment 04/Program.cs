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

            Console.Write("Please enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Reversed string: ");

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }

            Console.WriteLine();

            #endregion
        }
    }
}
