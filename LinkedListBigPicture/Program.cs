LinkedListBigPicture.LinkedList<int> list = new LinkedListBigPicture.LinkedList<int>();
int[] arr = new int[] {9,5,6,4,8,9,4,1};


list.CopyTo(arr, 2);
foreach (var item in list)
{
    Console.WriteLine(item);
}

