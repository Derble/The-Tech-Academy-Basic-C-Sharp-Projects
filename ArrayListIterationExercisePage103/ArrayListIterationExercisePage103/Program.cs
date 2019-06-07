using System;
using System.Collections.Generic;


namespace ArrayListIterationExercisePage103
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //1.Create a one-dimensional Array of strings.
            //Ask the user to input some text.
            //Create a loop that goes through each string in the Array, adding the user’s text to the string.
            //Then create a loop that prints off each string in the Array on a separate line.

            string[] colors = new string[] { "blue", "purple", "green", "yellow", "gray", "black", "pink" };
            Console.WriteLine("What's your favorite color?");
            string favColor = Console.ReadLine();
            for (int j = 0; j < colors.Length; j++)
            {
                colors[j] = favColor;
            }
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }
            
            Console.ReadLine();



            //2.Create an infinite loop.
            /*
            for (int k = 0; k >= 0; k++)
            {
                Console.WriteLine(k);
                k = k++; 
            }
            */



            //3.Fix the infinite loop so it will execute.

            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine(k);
            }
            Console.ReadLine();



            //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            //Writes evens to 20 starting at 2
            for (int m = 2; m < 21; m = m +2)
            {
                Console.WriteLine(m);
            }
            Console.ReadLine();



            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            //multiples of 2 up to and including 256
            for (int x = 2; x <= 256; x = x * 2)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();



            //6.Create a List of strings where each item in the list is unique.
            //Ask the user to select text to search for in the List.
            //Create a loop that iterates through the list and then displays the 
            //index of the array that contains matching text on the screen.
            //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //8.Add code to that above loop that stops it from executing once a match has been found.

            /*
            List<string> favoriteColor = new List<string>();
            favoriteColor.Add("red");
            favoriteColor.Add("yellow");
            favoriteColor.Add("blue");
            favoriteColor.Add("green");
            favoriteColor.Add("orange");
            favoriteColor.Add("violet");
            favoriteColor.Add("salmon");

            Console.WriteLine("Is your favorite color in the list? Type your favorite color to see:");
            string answerColor = Console.ReadLine();
            bool found = false;
            
            for (int y = 0; y < favoriteColor.Count; y++)
            {
                
                if (favoriteColor[y] == answerColor)
                {
                    found = true;
                }
                
            }

            if (found == true)
            {
                Console.WriteLine("Your answer matches an entry in the list at index: " + favoriteColor.IndexOf(answerColor));
            }
            else if (found == false)
            {
                Console.WriteLine("The color you entered is not in the list");
            }
            Console.ReadLine();
            */



            //9. Create a List of strings that has at least two identical strings in the List. 
            //Ask the user to select text to search for in the List. 
            //Create a loop that iterates through the list and then displays the indices of the 
            //array that contain matching text on the screen.
            //10. Add code to that above loop that tells a user if they put in text that isn’t in the List.

            List<string> cityNames = new List<string>() { "Portland", "Vancouver", "Toronto", "San Francisco", "Vancouver", "San Diego" };
            Console.WriteLine("Is there a duplicate city in the list? Type in a city to see:");
            string city = Console.ReadLine();

            /*//Original code for #9
            for (int z = 0; z < cityNames.Count; z++)
            {
                if (city == cityNames[z])
                {
                    Console.WriteLine("Your answer matches an entry in the list at index: " + z);
                }
            }*/

            //added/changed code for #9 and 10
            bool findCity = false;
            for (int y = 0; y < cityNames.Count; y++)
            {

                if (cityNames[y] == city)
                {
                    findCity = true;
                }

            }

            if (findCity == true)
            {
                for (int z = 0; z < cityNames.Count; z++)
                {
                    if (city == cityNames[z])
                    {
                        Console.WriteLine("Your answer matches an entry in the list at index: " + z);
                    }
                }
            }
            else if (findCity == false)
            {
                Console.WriteLine("The city you entered is not in the list");
            }
            Console.ReadLine();


            //11. Create a List of strings that has at least two identical strings in the List. 
            //Create a foreach loop that evaluates each item in the list, and 
            //displays a message showing the string and whether or not it has already appeared in the list.

            //ideas
            //if count > 1 it has already appeared in list
            //bool for count more than one true

            List<string> pokemonNames = new List<string>() { "Pikachu", "Bulbasaur", "Charmander", "Squirtle", "Bulbasaur", "Bulbasaur", "Charmander"};
       
            int index = 0;
            foreach (string pokemon in pokemonNames)
            {
                int count = 0;
                for (int p = 0; p < pokemonNames.Count; p++)
                {
                    if (pokemonNames[p] == pokemonNames[index])
                    {
                        count++;
                    }
                }
                Console.WriteLine(pokemon + ", appears " + count + " time(s)");
                index++;
            }
            Console.ReadLine();

            



            //Code that doesn't do what I needed it to, but keeping it around to reference for later projects
            //List<int> indexOfCity = new List<int>();
            /*
            foreach (string q in cityNames)
            {
                if (city == q)
                {
                    Console.WriteLine(cityNames.IndexOf(q));
                }
            }*/

            //need to create a counter to keep track of 
            //for (int z = 0; z < cityNames.Count; z++)
            //{

            //    if (city == cityNames[z])
            //    {
            //        //int indexNumber = cityNames.IndexOf(city);
            //        //indexOfCity.Add(indexNumber);
            //        Console.WriteLine("Your answer matches an entry in the list at index: " + z);
            //    }
            //    //Console.WriteLine(cityNames[z]);

            //}
            //Console.WriteLine("Your answer matches an entry in the list at index: " + cityNames.IndexOf(city));
            /*
            for (int w = 0; w < indexOfCity.Count; w++)
            {
                Console.WriteLine("Your answer matches an entry in the list at index: " + indexOfCity[w]);
            }
            //Console.WriteLine("Your answer matches an entry in the list at index: " + cityNames.IndexOf(city));
            */



        }
    }
}
