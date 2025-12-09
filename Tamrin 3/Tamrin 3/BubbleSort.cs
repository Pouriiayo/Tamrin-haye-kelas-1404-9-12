namespace FirstSort;

public static class BubbleSort
{
    public static void Bubblesort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            bool swapped = false;

            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break; //برای اینکه اگر مرتب شده بود دوباره شروع نکنه
            }
        }

    }
}


