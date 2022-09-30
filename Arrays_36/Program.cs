using System;
class Insert 
{
    public static void Main()
    {
        // DATA is an array of size N 
        // k is the element that we want to insert 
        const int N = 5; // Size of Array , fixed 
        int ESF = 0; // Elements So Far 
        bool insertElement(int DATA [] , intk )
        {   // If array is full , return false 
            if (ESF == N)
            {
                return false;
            }
            // Otherwise , insert element at ESF - 1 
            DATA[ESF] = k;
            ESF++; // Increment ESF by 1 
            return true;
        }
    }
}