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
            /*  //declaring an array without initializing
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
              Console.WriteLine("{0},{1},{2},{3}", classMates[0], classMates[1], classMates[2], classMates[3]);
             // Console.WriteLine(classMates);*/

            //start with int calling variable number of sets I want to make space for 21 seats make room for a new array obj with 21 seats
            /*  int[] numberofSeats = new int[21];
              string[] studentsInClass = new string[21];

              //nameOf Array[index] = Element;
              studentsInClass[0] = "Jordan";
              Console.WriteLine("Please enter in the name of the next student.");
              studentsInClass[1] = Console.ReadLine();

              //Great way to concatinate a Array
              Console.WriteLine(" second seat is in student The seat {0}.", studentsInClass[1]);



              Console.WriteLine("Please enter the age. of the person in the first seat");
              int[] ageOfStudentsInClass = new int[21];
              ageOfStudentsInClass[0] = int.Parse(Console.ReadLine());
              Console.WriteLine("The age of the student in the first seat is " + ageOfStudentsInClass[0]);

            //  string firstIndex = ageOfStudentsInClass[0].ToString();

      */
            string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chick Fil-A" };
            Console.WriteLine(restaurantsInMall.Length);

            //For review
            int[] myIntArrayAgain;
            //Declare an array when I know the elements
            char[] lettersInFirstName = { 'D', 'a', 'n', 'i', 'e', 'l' };
            //Declare and initialize an array when I DON'T know the elements
            string[] variableName = new string[42];

            //To practice using.Length, create a char array of the letters in your middle name
            //..and print the number of car's to the console.'
            //  char middleName;
            // char[] middleName = { 'F', 'A', 'I', 'T', 'H' };
            // Console.WriteLine(middleName.Length);
            // char[] middleName1 = new char[5];
            // Console.WriteLine(middleName1.Length);

            //Declare and initialize a string array.
            //using the Length property, print the Second to last element in the array.

            string[] fruitLoops = { "green", "purple", "Yellow", "orange", "Blue" };
            Console.WriteLine(fruitLoops.Length);
            Console.WriteLine(fruitLoops[3]);
            //  Console.WriteLine(fruitLoops.Length - 1);
            //  Console.WriteLine(fruitLoops[numRest - 2);
            //Length is not 0 index
            Console.WriteLine(fruitLoops[fruitLoops.Length - 2]);
            //build error
            //run time error.
            //IndexOf is a method used to search an array for a specified value and returns
            //the index position of the first matching value found.

            int[] bestYearsEver = { 1985, 1999, 1991, 2000, 1985 };
            Console.WriteLine(Array.IndexOf(bestYearsEver,1985));
            //LastIndexOf is a method used to search an array for a specified value and returns
            //the index position of the Last matching value found.
            Console.WriteLine(Array.LastIndexOf(bestYearsEver, 1985));

            //Reverse Method
            int[] palindromeNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(palindromeNumbers[0]);
            Array.Reverse(palindromeNumbers);
            Console.WriteLine(palindromeNumbers[0]);


        }
    }
}
