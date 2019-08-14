using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test01
{
    public class Box<T>
    {
        private List<T> boxItems;

        public int Count
        {
            get
            {
                return boxItems.Count;
            }
        }

        public Box()
        {
            boxItems = new List<T>();
        }

        public void Add(T element)
        {
            boxItems.Add(element);
        }

        public T Remove()
        {
            if (Count > 0)
            {
                T lastElement = boxItems.Last();
                boxItems.RemoveAt(Count - 1);

                return lastElement;
            }

            throw new InvalidOperationException("Can not remove element from empty collection");
        }

        public void Swap(int positonOne, int positonTwo)
        {


            var x = boxItems[positonOne];
            boxItems[positonOne] = boxItems[positonTwo];
            boxItems[positonTwo] = x;


        }

        public override string ToString()
        {
            var x = new StringBuilder();

            foreach (var item in boxItems)
            {
                x.AppendLine($"{item.GetType()}: {item}");
            }

            return x.ToString();
        }
    }
}
