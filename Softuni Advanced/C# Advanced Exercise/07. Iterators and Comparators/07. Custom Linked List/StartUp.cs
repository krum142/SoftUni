using System;

namespace CustomLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var doublyLinkedList = new DoublyLinkedList<string>();

            doublyLinkedList.AddLast("str1");
            doublyLinkedList.AddLast("str2");
            doublyLinkedList.AddLast("str3");

            var array = doublyLinkedList.ToList();

            foreach (var item in doublyLinkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
