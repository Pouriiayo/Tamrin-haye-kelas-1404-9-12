namespace FirstSearch;

public static class LinearSearch
{
    public static int Linear(int[] array, int x)
    {
        for (int i = 0; i < array.Length; i++)
        {

            if (array[i] == x) return i;
        }

        return -1;
    }
}
