using System;
using System.Collections;

namespace HomeTasks
{
    public class IteratorGenerator : IEnumerator
    {
        private readonly int[] _array;
        private int _currentIndex = -1;
        private int N;

        public IteratorGenerator(int n)
        {
            if (n <= 0) return;
            _array = new int[n + 1];
            for (var i = 0; i < _array.Length; i++)
            {
                _array[i] = i;
            }
            N = n;
        }

        public object Current
        {
            get
            {
                if (_currentIndex == -1)
                {
                    throw new InvalidOperationException("Enumeration not started");
                }

                if (_currentIndex == _array.Length)
                {
                    throw new InvalidOperationException("Past end of list.");
                }

                //return _array[_currentIndex];
                while (N > 0)
                {
                    N--;
                    return N;
                }
                return 0;
            }
        }


        public bool MoveNext()
        {
            if (_currentIndex >= _array.Length - 1)
            {
                return false;
            }

            return ++_currentIndex < _array.Length;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
        
    }
}
