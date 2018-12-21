using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EvenIterators
{
    class MyEvenEnumerable : IEnumerable
    {
        int[] array;

        public MyEvenEnumerable(int[] array)
        {
            this.array = array;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in array)
            {
                if (item % 2 == 0)
                    yield return item;
            }
        }
    }
}
