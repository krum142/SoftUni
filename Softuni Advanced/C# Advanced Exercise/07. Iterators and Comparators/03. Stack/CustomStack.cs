using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> list;

        public CustomStack()
        {
            list = new List<T>();
        }
        public void Push(List<T> items)
        {
            list.AddRange(items);
        }
        public void Pop()
        {
            if(list.Count - 1 < 0)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                list.RemoveAt(list.Count - 1);
            }

        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.list.Count - 1; i >= 0; i--)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
