using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FroggyJump
{
    public class Lake : IEnumerable<int>
    {
        private List<int> jumps;

        public Lake(List<int> items)
        {
            this.jumps = new List<int>();
            jumps.AddRange(items);
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < jumps.Count; i++)
            {
                if(i % 2 == 0)
                {
                    yield return jumps[i];
                }
            }
            for (int j = jumps.Count - 1; j >= 0; j--)
            {
                if (j % 2 == 1)
                {
                    yield return jumps[j];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
