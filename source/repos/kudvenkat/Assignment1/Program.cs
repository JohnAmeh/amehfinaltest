using System;

class Program
{ 
    static void Main()
    {
        AddNum();
    }




    // The Start
    static int n;
    static void AddNum()
    {
        int i;
        int sum = 0;

        int NbrOfItems;


        Console.Write("\n\n");
        Console.Write("1. This program add a series of numbers together. \n2. To add 3 different numbers; e.g, a+b+c, enter 3.");
        Console.Write("\n\n----------------------------------------------");


        Console.Write("\n");
        Console.Write("3. How many numbers do you want to add together?:   ");
        NbrOfItems = Int32.Parse(Console.ReadLine());


        Console.WriteLine("Go ahead and input the {0}  numbers you wish to add.", NbrOfItems);
        Console.Write("\n");


        int Fnum = Convert.ToInt32(Console.ReadLine());
        for (i = 1; i <= NbrOfItems - 1; i++)
        {
            Console.Write("\n\n Input the numbers : ");
            n = int.Parse(Console.ReadLine());
            sum = sum + n;

        }
        Console.Write("The sum is {0} ", Fnum + sum);

    }


} //end
