using System.Runtime.InteropServices;

namespace SecondSearch;

public static class BinarySearch
{
    public static int Binary(int[] arr , int x)
    {
        int end = arr.Length - 1  ;
        int start = 0;
        while (start <= end) {

            int middle = start + (end - start) / 2;
            int value = arr[middle] ;


            if (value < x) start = middle + 1;
            else if (value > x) end = middle - 1;
            else return middle;
        }

        return -1;
    }
}
