using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***** Palak Arora - 301112908 *****

namespace Palak_Arora_Exercise01
{
    class Program
    {
        static void Main(string[] args)   //main method
        {
            // Exercise 1a - Func<> delegate predicate
            Console.WriteLine("\n\n ***** Exercise 1a *****");
            Console.Write("Enter first string: ");   //reading input string
            string str1 = Console.ReadLine();

            Console.Write("Enter second string: ");  //reading input string
            string str2 = Console.ReadLine();

            Console.Write("Enter third string: ");   //reading input string
            string str3 = Console.ReadLine();

            // Func delegate using lambda and the method Minimum
            Func<string, string, string, string> smallest = (string string1, string string2, string string3) => Minimum(str1, str2, str3); //the forth string is for the output
            string str = smallest(str1, str2, str3);  //the output string is smallest out of the three strings entered.
            Console.WriteLine("The smallest string is: " + str);  //displaying the result

            // Exercise 1b - Action<> delegate predicate
            Console.WriteLine("\n\n ***** Exercise 1b *****");

            Console.Write("Enter first grade: ");             // Read input grades
            int g1 = (int)Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second grade: ");             // Read input grades
            int g2 = (int)Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter third grade: ");             // Read input grades
            int g3 = (int)Convert.ToDouble(Console.ReadLine());

            // Action delegate using lambda and the method AvgGrade
            Action<int, int, int> average = AvgGrade;
            average(g1, g2, g3); //calling average action<> delegate predicate
            Console.ReadLine();

        }//end of main-method
        public static string Minimum(string string1, string string2, string string3) //method that uses buil-in Func<> delegate predicate to return smallest string
        {
            if (string1.Length < string2.Length)   //checks if string1 is smaller than other two strings
            {
                if (string1.Length < string3.Length) 
                { return string1; }

                else
                { return string3; }
            }
            else if (string2.Length < string3.Length)  //checks if strings2 is smaller than string 3
            {
                return string2;
            }
            else
            {
                return string3;
            }
        }//end of Minimum Method
        
        public static void AvgGrade(int value1, int value2, int value3)  //method that uses built-in Action<> delegate predicate to get average of grades
        {
            int result = (value1 + value2 + value3) / 3;  //calculating average
            Console.WriteLine("The average is: " + result);

        }//end AvgGrade method
    }

}//end namespace
