using System;

namespace Algorithms.Algorithms
{
    public static class InsertionSort
    {
        public static int[] Sort(int [] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while(j >= 0 && array[j] > key)
                {   
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
            return array;
        }
    }
}