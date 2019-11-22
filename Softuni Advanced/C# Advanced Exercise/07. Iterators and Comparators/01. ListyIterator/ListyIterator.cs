using System;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> items;
        private int index;
        public ListyIterator(List<T> items)
        {
            this.items = items;
            this.index = 0;
        }

        public bool Move()
        {

            if(HasNext())
            {
                index++;
                return true;
            }

            return false;
            //index
            //currentIndex < items.lengt
            //return ture// false  
        }
        public bool HasNext()
        {
            if (this.index < this.items.Count - 1)
            {
                return true;
            }

            return false;
        }
        public void Print()
        {
            if(this.items.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(this.items[this.index]);
        }
    }
}
