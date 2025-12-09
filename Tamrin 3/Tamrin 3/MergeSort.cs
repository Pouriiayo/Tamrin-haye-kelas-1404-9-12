namespace SecondSort;

public static class MergeSort
{
    public static void Mergesort(int[] array)
    {
        int length = array.Length;
        if (length <= 1) return;

        int middle = length / 2;

        int[] leftarray = new int[middle];
        int[] rightarray = new int[length - middle];

        int i = 0;
        int j = 0;

        for (; i < length; i++)
        {
            if (i < middle)
            {
                leftarray[i] = array[i];
            }
            else
            {
                rightarray[j] = array[i];
                j++;
            }
        }

        Mergesort(leftarray);
        Mergesort(rightarray);


        Merge(array, leftarray, rightarray);


    }

    public static void Merge(int[] array, int[] leftarray, int[] rightarray)
    {

        int leftsize = array.Length / 2;
        int rightsize = array.Length - leftsize;

        int i = 0, l = 0, r = 0;

        while (l < leftsize && r < rightsize)
        {
            if (leftarray[l] < rightarray[r])
            {
                array[i] = leftarray[l];
                l++;
                i++;
            }
            else
            {
                array[i] = rightarray[r];
                r++;
                i++;
            }
        }

        while (l < leftsize)
        {
            array[i] = leftarray[l];
            i++;
            l++;
        }

        while (r < rightsize)
        {
            array[i] = rightarray[r];
            i++;
            r++;
        }
    }
}

