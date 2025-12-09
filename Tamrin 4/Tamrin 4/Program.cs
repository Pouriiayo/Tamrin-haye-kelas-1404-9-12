//پوریا یوسفی
//تمرین 4

using FirstSearch;
using SecondSearch;
using SecondSort;
int[] arr = {2 , 9 , -1 , 15 , 18 };


Console.WriteLine("Dar index " + LinearSearch.Linear(arr, 9) + " Peyda shod");
MergeSort.Mergesort(arr);
Console.WriteLine("Dar index " + BinarySearch.Binary(arr ,9) + " Peyda shod");