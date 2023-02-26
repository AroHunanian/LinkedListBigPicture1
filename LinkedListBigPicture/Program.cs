LinkedListBigPicture.LinkedList<int> list = new LinkedListBigPicture.LinkedList<int>();
LinkedList<int> a 
list.Add(5);
list.Add(6);
list.Add(7);
list.PrintAll(list.head);
bool isRemoved = list.Remove(5);
list.PrintAll(list.head);
Console.WriteLine("list tail");
list.Print(list.tail);

