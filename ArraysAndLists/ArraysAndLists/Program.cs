using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        //int[] numArray;//"here I have an integer array called num array but have to instantiate it
        //int[] numArray = new int[5];//must define length of it before you begin in C#
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;//can change parts of array but still have to initial size of array limited, cannot change

        ////list more adaptable than arrays.

        //Console.WriteLine(numArray[3]);
        //Console.WriteLine(numArray1[3]);
        //Console.WriteLine(numArray2[3]);
        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();



        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        List<string> stringList = new List<string>();
        stringList.Add("Hello");
        stringList.Add("Jesse");

        //byte[] byteArray = new byte[5000];
        //arrays used for something very small and fixed or for very large quantities

        Console.WriteLine(intList[0]);
        Console.WriteLine(stringList[0]);
        Console.ReadLine();
    }
}

