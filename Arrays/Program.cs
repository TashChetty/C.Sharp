using System;
class FindMax { 


    public static void Main()
{
    int[] marks = { 25, 60, 95, 89, 62, 15 };
    int largeNum = marks[0];

    for (int i = 1; i < 6; i++)
    {
        if (marks[i] > largeNum)
        {
            largeNum = marks[i];

        }
    }
    System.Console.WriteLine("The largest number is :  " + largeNum);

}

}

