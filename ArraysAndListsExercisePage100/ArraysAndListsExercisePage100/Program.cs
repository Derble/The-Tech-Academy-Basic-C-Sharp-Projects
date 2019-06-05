using System;
using System.Collections.Generic;


namespace ArraysAndListsExercisePage100
{
    class Program
    {
        static void Main()
        {
            //Create an array of strings.
            //Ask the user to select an index of the Array and then display the string at that index on the screen.
            string[] stringArray = new string[] { "Leeloo", "Zorg", "Korben Dallas", "Ruby Rhod", "Father Vito Cornelius"};
            Console.WriteLine("Enter the index of the array that you would like to see:");
            int fifthElement = Convert.ToInt32(Console.ReadLine());
            if (fifthElement >= 0 && fifthElement < 5)
            {
                Console.WriteLine("Your chosen Fifth Element character is " + stringArray[fifthElement] + "!");
            }
            else
            {
                Console.WriteLine("There is no data at that index.");
            }
            Console.ReadLine();

            //Create an array of integers.
            //Ask the user to select an index of the Array and then display the integer at that index on the screen.
            int[] intArray = new int[] { 2, 3, 5, 7, 11, 13, 17, 19 };
            Console.WriteLine("Enter the index of the array that you would like to see:");
            int primeNumber = Convert.ToInt32(Console.ReadLine());
            if (primeNumber >= 0 && primeNumber < 8)
            {
                Console.WriteLine("The prime number at that index is " + intArray[primeNumber] + "!");
            }
            else
            {
                Console.WriteLine("There is no data at that index.");
            }
            Console.ReadLine();

            //Create a List of strings. 
            //Ask the user to select an index of the List and then display the content at that index on the screen.

            List<string> stringList = new List<string>();
            stringList.Add("Luke Skywalker");
            stringList.Add("Leia Organa");
            stringList.Add("Han Solo");
            stringList.Add("Chewbacca");
            stringList.Add("Darth Vader");
            stringList.Add("R2D2");
            stringList.Add("C3PO");
            stringList.Add("Obi Wan Kenobi");
            Console.WriteLine("Enter the index of the list that you would like to see:");
            int starWars = Convert.ToInt32(Console.ReadLine());
            if (starWars >= 0 && starWars < 8)
            {
                Console.WriteLine("Your chosen Star Wars character is " + stringList[starWars] + "!");
            }
            else
            {
                Console.WriteLine("There is no data at that index.");
            }
            Console.ReadLine();
        }
    }
}
