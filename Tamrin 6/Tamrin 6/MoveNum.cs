namespace MoveNum;

public static class Movenum
{
    public static int[] MoveZero(int[] arr)
    {
        int index = 0;
        int temp;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
                index++;
            }
        }

        return arr;
    }

}

