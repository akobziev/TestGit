using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EvenIterators
{
    class PositiveEnumerator : IEnumerator
    {
        int[] array;
        int currentIndex = 0;

        public PositiveEnumerator(int[] array)
        {
            this.array = array;
        }

        public object Current
        {
            get
            {
                if (array[currentIndex] > 0)
                {
                    return array[currentIndex];
                }

                return 0;
            }
        }

        public bool MoveNext()
        {
            return (int)Current <= array.Length;
        }

        public void Reset()
        {
            throw new NotSupportedException();
        }
    }
}
