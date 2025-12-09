namespace RotateArray;

using Reverse;
public static class RotateArray
{
    public static void Rotate(int[] nums , int k)
    {
        int n = nums.Length;
        k = k % n;

        ReverseArray.Reverse(nums , 0 , n -1);
        ReverseArray.Reverse(nums, 0, k - 1);
        ReverseArray.Reverse(nums, k, n - 1);
    }
}
