//پوریا یوسفی
//تمرین 6
using MoveNum;
using GetValidArrayInput;
int[] arr = GetValidInput.ForceGetIntInput();

MoveNum.Movenum.MoveZero(arr);
foreach (int i in arr)
{
    Console.Write(i);
}