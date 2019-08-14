using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodString
{
    public class Box<T>
        where T : IComparable<T>
    {
        private List<T> boxStuff;

        public Box()
        {
            boxStuff = new List<T>();
        }
        public int CountGrater { get; private set; }
        public void Add(T items)
        {
            boxStuff.Add(items);
        }
        public void Compare(T item)
        {
         
            foreach (var CurrentStuff in this.boxStuff)
            {
                if(CurrentStuff.CompareTo(item) > 0)
                {
                    this.CountGrater++;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder Sb = new StringBuilder();

            foreach (var stuff in this.boxStuff)
            {
                Sb.AppendLine(stuff.ToString());
            }

            return Sb.ToString();
        }
    }
}
