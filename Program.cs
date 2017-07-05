using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring an array without initializing
            int[] myFirstArray;


            //declaring and initializing a second array
            string[] myStringArray = { "First", "Second", "Third", "Fourth" };


            //declare and initialize a char array with the letters of your last name.
            char[] myLastName = { 'L', 'O', 'V', 'E' };

            //I want my console to print three elements of my array

            Console.WriteLine(myLastName[0]);
            Console.WriteLine(myLastName[3]);
            Console.WriteLine(myLastName[1]);
            //create the following arrays and print using the correct index numbers:
            //array of top 10 vacation spots
            string[] vacationSpots = { "Myrtel Beach", "Hawaii", "Los Vagas", "San diegio", "Tokyo", "Cozumel", "Jamacia", "Paris", "Mexico", "Chili" };
            //print the first and last vacation spots
            Console.WriteLine(vacationSpots[0]);
            Console.WriteLine(vacationSpots[9]);
            //array of the ages of 3 children you know
            int[] childAge = { 14, 16, 18 };
            //print each child's age
            Console.WriteLine(childAge[0]);
            Console.WriteLine(childAge[1]);
            Console.WriteLine(childAge[2]);



            //array of GPA's on a 4.0 scale of 8 students - you don't have to print
            double[] studentGpas = { 1.0d, 2.0d, 3.0d, 4.0d, 1.5d, 2.5d, 3.5d, 1.4d, };
            //array of the first letter of 4 of your classmates names who are sitting near you
            char[] classMates = { 'A', 'B', 'C', 'D' };
            //print all four on the same line.
            Console.WriteLine(classMates.Length);
            //  Console.Write(classMates[0]);
            //  Console.Write(classMates[1]); 
            //  Console.Write(classMates[2]);
            //  Console.Write(classMates[3]);
          //  Console.WriteLine(classMates[0 + 1 + 2]);
            Console.WriteLine("{0}, {1}, { 2}, { 3}", classMates[0], classMates[1], classMates[2]);
           // Console.WriteLine(classMates);



        }
    }
}
