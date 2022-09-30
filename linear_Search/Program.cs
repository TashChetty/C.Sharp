using System;
class LinearSearch
{


    public static void Main()
    {
        int[] myData = { 30, 80, 25, 21 };
        int searchData = 90;
        int totalCount = myData.Count();
        int i;
        for (i = 0; i < totalCount; i++)
        {

            if (myData[i] == searchData)
            {
                Console.WriteLine("We found our data: " + searchData +  " in position: " + (i+1));
                break;
            }

                
        }
            if (i == totalCount)
                Console.WriteLine("We did not find our data: ");
    }
}