using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***** Palak Arora - 301112908 *****

namespace Palak_Arora_Exercise02
{
    public delegate bool GradesPredicate(double grade);  //a delegate that takes input as a double and returns a bool
    class Program
    {
        static void Main(string[] args) //main method
        {
            double[] gradesArray = { 55.5, 11.11, 22.2, 3.33, 44.4, 89.3, 99.9, 64.15, 50, 49.99 };  //array containing grades value.

            Console.Write("\nThe grades of a student: \n");
            foreach (double item in gradesArray)
            {
                Console.Write($" {item} ");
            }
            Console.WriteLine();
            // Filter grades greater than or equal to 50 using an implicit lambda statement
            GradesFilter(gradesArray, grade => { return grade >= 50; });   
           
            Console.ReadLine();

        } // end Main


        private static void GradesFilter(double[] gradesArray, GradesPredicate predicate)  // method that displays only the grades that are equal or more than 50
        {
            Console.Write("\nThe grades which are greater than or equal to 50 are as follows: \n");

            // Iterate over each element in the array
            foreach (double item in gradesArray)
            {
                // Print elements that satisfies the predicate
                if (predicate(item))
                {
                    Console.Write($" {item} "); // print item followed by a space
                }
            }
            Console.WriteLine();
        } // end method GradesFilter

    }//end program
}//end namespace
